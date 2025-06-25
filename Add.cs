using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class Add:ICalculation
    {
        double value;
        public Add(double val) => value = val;
        public double Perform(double number) => number + value;
    }
}
