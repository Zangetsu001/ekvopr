using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Point<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }
}
