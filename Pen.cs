using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Pen:Tovar
    {
        public int Kvo;

        public override void Calc()
        {
            Console.WriteLine($"{Name}: {Kvo} шт * {Price} = {Kvo * Price} руб.");
        }
    }
}

