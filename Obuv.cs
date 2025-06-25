using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Obuv:Tovar
    {
        public int Quantity { get; set; }
        public Obuv(string name, double price, int quantity) : base(name, price)
        {
            Quantity = quantity;
        }
        public override double CalcSum() => Price * Quantity;
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество: {Quantity}, Сумма: {CalcSum()}");
        }
    }
}
