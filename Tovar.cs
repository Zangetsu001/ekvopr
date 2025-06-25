using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Tovar
    {
        public string Name;
        public int Price;

        public virtual void Calc() { }
    }

    class Book : Tovar
    {
        public int Kvo;

        public override void Calc()
        {
            Console.WriteLine($"{Name}: {Kvo} шт * {Price} = {Kvo * Price} руб.");
        }

    }
}
