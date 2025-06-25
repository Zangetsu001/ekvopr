using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class Program
    {
        static double Calculate(double x, ICalculation a, ICalculation b)
        {
            return b.Perform(a.Perform(x));
        }

        static void Main()
        {
            Console.WriteLine(Calculate(5, new Add(3), new Multiply(2))); // (5+3)*2 = 16
        }
    }
}
