using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> colors = new List<string> { "красный", "синий", "зеленый" };

            Console.WriteLine("Начальный список:");
            colors.ForEach(Console.WriteLine);

            for (int i = 0; i < colors.Count; i++)
                colors[i] = colors[i].ToUpper();

            Console.WriteLine("\nПосле преобразования в верхний регистр:");
            colors.ForEach(Console.WriteLine);

            Console.WriteLine($"\nКоличество элементов: {colors.Count}");

            colors.Add("ЖЁЛТЫЙ");
            Console.WriteLine("\nПосле добавления в конец:");
            colors.ForEach(Console.WriteLine);

            colors.Insert(0, "ФИОЛЕТОВЫЙ");
            Console.WriteLine("\nПосле добавления в начало:");
            colors.ForEach(Console.WriteLine);

            if (colors.Count > 2)
                colors.RemoveAt(2);

            Console.WriteLine("\nПосле удаления третьего элемента:");
            colors.ForEach(Console.WriteLine);

            colors.Reverse();
            Console.WriteLine("\nПосле разворота:");
            colors.ForEach(Console.WriteLine);
        }
    }
}
