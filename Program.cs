using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int SumDelegate(int m, int n);

class Program
{
    public static int Sum(int m, int n)
    {
        int s = 0;
        for (int i = m; i <= n; i++) s += i;
        return s;
    }

    static void Main()
    {
        SumDelegate sum = Sum;
        Console.WriteLine("Сумма: " + sum(1, 5));
        Console.WriteLine("Сумма: " + sum(10, 20));
        Console.WriteLine("Сумма: " + sum(100, 105));
    }
}
