using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle<double>(3, 4, 5);
            triangle.Print();
            Console.WriteLine("Площадь: " + triangle.Area());
        }
    }
}
