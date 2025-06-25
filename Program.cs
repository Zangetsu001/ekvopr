using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate double AvgDelegate(int m, int n);

namespace ConsoleApp46
{
    internal class Program
    {
        static double Average(int m, int n)
        {
            int sum = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return (double)sum / count;
        }
        static void Main(string[] args)
        {
            AvgDelegate del = Average;
            Console.WriteLine(del(1, 10));
            Console.WriteLine(del(5, 15));
            Console.WriteLine(del(10, 20));
        }
    }
}
