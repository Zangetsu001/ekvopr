using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string userText = Console.ReadLine();

            Console.WriteLine("\nДоступные цвета:");
            foreach (var color in Enum.GetValues(typeof(TextColor)))
            {
                Console.WriteLine($"{(int)color}. {color}");
            }

            Console.Write("\nВведите номер цвета: ");
            if (int.TryParse(Console.ReadLine(), out int selectedColor))
            {
                Printer.Print(userText, selectedColor);
            }
            else
            {
                Console.WriteLine("Ошибка ввода!");
            }

            Console.ReadLine();
        }
    }
}
