using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            Console.WriteLine("Число PI: " + obj.GetPi());
            Console.WriteLine("Целое число: " + obj.GetNumber());
            Console.WriteLine("Квадрат числа 5: " + obj.Square(5));
            Console.WriteLine("Квадратный корень из 25: " + obj.Sqrt(25));

            Console.ReadLine();
        }
    }
}
