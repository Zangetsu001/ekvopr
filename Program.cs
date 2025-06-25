using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(-1, 4);
            var p3 = new Point(-2, -2);
            var p4 = new Point(3, -1);

            p1.Print(); p2.Print(); p3.Print(); p4.Print();
            Point.PrintStats();
        }
    }
}
