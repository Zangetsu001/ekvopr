using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class Multiply:ICalculation
    {
        double factor;
        public Multiply(double f) => factor = f;
        public double Perform(double number) => number * factor;
    }
}
