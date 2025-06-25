using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer[] comps = {
            new Computer { Model = "Model A", RAM = 8, HDD = 500 },
            new Computer { Model = "Model B", RAM = 16, HDD = 1000 }
        };

            double total = 0;
            foreach (var c in comps)
            {
                double cost = c.GetCost();
                Console.WriteLine($"{c.Model} стоит {cost} руб.");
                total += cost;
            }

            Console.WriteLine($"Общая стоимость: {total} руб.");
        }
    }
}
