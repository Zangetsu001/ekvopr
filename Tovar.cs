using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    abstract class Tovar
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Tovar(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract double CalcSum();
        public virtual void Print()
        {
            Console.WriteLine($"Название: {Name}, Цена: {Price}");
        }
    }
}
