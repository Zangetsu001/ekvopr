using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tour t = new Tour();
            t.TourCalc();
            t.TourCalc("Молдова");
            t.TourCalc("Румыния", 5);
        }
    }
}
