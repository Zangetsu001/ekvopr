using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate double TriangleDelegate(double a, double b, double c);

namespace ConsoleApp43
{
    internal class Program
    {
        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            TriangleDelegate del = S;

            Console.WriteLine($"Площадь: {del(3, 4, 5)}");
            Console.WriteLine($"Площадь: {del(6, 8, 10)}");
            Console.WriteLine($"Площадь: {del(7, 7, 7)}");
        }
    }
}
