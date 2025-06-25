using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Odejda:Tovar
    {
        public string Size { get; set; }
        public Odejda(string name, double price, string size) : base(name, price)
        {
            Size = size;
        }
        public override double CalcSum() => Price;
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Размер: {Size}, Сумма: {CalcSum()}");
        }
    }
}
