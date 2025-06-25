using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Posuda:Tovar
    {
        public double Weight { get; set; }
        public Posuda(string name, double price, double weight) : base(name, price)
        {
            Weight = weight;
        }
        public override double CalcSum() => Price * Weight;
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Масса: {Weight}, Сумма: {CalcSum()}");
        }
    }
}
