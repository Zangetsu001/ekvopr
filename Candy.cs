using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp36
{
    internal class Candy:Tovar
    {
        public double Ves;

        public override void Calc()
        {
            Console.WriteLine($"{Name}: {Ves} кг * {Price} = {Ves * Price} руб.");
        }
    }
}
