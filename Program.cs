using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k1 = new Kupyura("Рубль", 50, 10);
            var k2 = new Kupyura("Доллар", 100, 2);
            var k3 = new Kupyura("Евро", 200, 5);
            k1.Print(); k2.Print(); k3.Print();

            Console.WriteLine("Можно ли купить за 500: " + k3.CanPay(500));
        }
    }
}
