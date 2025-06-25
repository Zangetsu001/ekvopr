using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Calculator
    {
        public static double Add(double a, double b) => a + b;
        public static double Sub(double a, double b) => a - b;
        public static double Mul(double a, double b) => a * b;
        public static double Div(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Деление на ноль!");
            return a / b;
        }
    }
}
