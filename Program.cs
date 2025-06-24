using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите модель ноутбука:");
            string model = Console.ReadLine();

            Console.WriteLine("Введите производителя:");
            string manufacturer = Console.ReadLine();

            Console.WriteLine("Введите цену:");
            double price = double.Parse(Console.ReadLine());

            Notebook nb = new Notebook(model, manufacturer, price);

            Console.WriteLine("\nИнформация о ноутбуке:");
            nb.PrintInfo();

            Console.ReadLine();
        }
    }
}
