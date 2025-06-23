using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class MyClass:IMyInterface
    {
        public double GetPi()
        {
            return Math.PI;
        }

        public int GetNumber()
        {
            return 42; 
        }

        public double Square(double x)
        {
            return x * x;
        }

        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
