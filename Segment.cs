using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Segment<T> where T : struct, IConvertible
    {
        private T x1, y1, x2, y2;

        public Segment(T x1, T y1, T x2, T y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Print()
        {
            Console.WriteLine($"Начало: ({x1}, {y1}), Конец: ({x2}, {y2})");
        }

        public double Length()
        {
            double dx = Convert.ToDouble(x2) - Convert.ToDouble(x1);
            double dy = Convert.ToDouble(y2) - Convert.ToDouble(y1);
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
