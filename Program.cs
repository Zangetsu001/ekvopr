using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tovar[] tovary = {
            new Book { Name = "Роман", Price = 10, Kvo = 2 },
            new Pen { Name = "Ручка", Price = 3, Kvo = 5 },
            new Candy { Name = "Конфеты", Price = 8, Ves = 0.5 }
        };

            foreach (var t in tovary)
                t.Calc();
        }
    }
}
