using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tovar[] items = {
            new Obuv("Кроссовки", 120, 2),
            new Odejda("Куртка", 150, "L"),
            new Posuda("Тарелка", 20, 3)
        };

            foreach (var item in items)
            {
                item.Print();
                Console.WriteLine();
            }
        }
    }
}
