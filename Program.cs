using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(4, 0, "B");
            Point C = new Point(5, 3, "C");
            Point D = new Point(2, 5, "D");
            Point E = new Point(-1, 3, "E");

            Figure figure = new Figure(A, B, C, D, E);


            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
