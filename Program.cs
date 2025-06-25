using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point<int>(3, 4);
            var p2 = new Point<uint>(10u, 20u);
            var p3 = new Point<double>(5.5, 6.6);

            p1.Print();
            p2.Print();
            p3.Print();
        }
    }
}
