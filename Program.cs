using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Program
    {
        static void PrintShape(IShape shape)
        {
            Console.WriteLine(shape.ToString());
            Console.WriteLine("Периметр: " + shape.Perimeter());
            Console.WriteLine("Площадь: " + shape.Area());
        }

        static void Main()
        {
            PrintShape(new Triangle(3, 4, 5));
            PrintShape(new Disk(7));
        }
    }
}
