using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Год: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("День: ");
            int d = int.Parse(Console.ReadLine());

            var date = new DateClass(y, m, d);
            Console.WriteLine("Текущая: " + date.Data.ToShortDateString());
            Console.WriteLine("Вчера: " + date.PrevDay().ToShortDateString());
            Console.WriteLine("Завтра: " + date.NextDay().ToShortDateString());
        }
    }
}
