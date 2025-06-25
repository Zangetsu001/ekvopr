using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Triangle<T> where T : struct, IConvertible
    {
        private T a, b, c;

        public T A
        {
            get => a;
            set => a = value;
        }

        public T B
        {
            get => b;
            set => b = value;
        }

        public T C
        {
            get => c;
            set => c = value;
        }

        public Triangle(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Print()
        {
            Console.WriteLine($"Стороны: A = {a}, B = {b}, C = {c}");
        }

        public double Area()
        {
            double da = Convert.ToDouble(a);
            double db = Convert.ToDouble(b);
            double dc = Convert.ToDouble(c);
            double p = (da + db + dc) / 2;
            return Math.Sqrt(p * (p - da) * (p - db) * (p - dc));
        }
    }
}
