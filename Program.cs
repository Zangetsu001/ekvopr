using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tovar[] tovary = {
            new Tovar { Name = "Молоко", Price = 15, Kvo = 2 },
            new Tovar { Name = "Хлеб", Price = 5, Kvo = 3 }
        };

            int total = 0;
            foreach (var t in tovary)
            {
                t.Show();
                total += t.GetCost();
            }

            Console.WriteLine($"Итого: {total} руб.");
        }
    }
}
