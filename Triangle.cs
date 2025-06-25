using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Triangle:IShape
    {
        double a, b, c;
        public Triangle(double a, double b, double c) { this.a = a; this.b = b; this.c = c; }
        public double Perimeter() => a + b + c;
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override string ToString() => $"Треугольник: a={a}, b={b}, c={c}";
    }
}
