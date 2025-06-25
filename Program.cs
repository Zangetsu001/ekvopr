using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var seg = new Segment<int>(1, 2, 4, 6);
            seg.Print();
            Console.WriteLine("Длина: " + seg.Length());
        }
    }
}
