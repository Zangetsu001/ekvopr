using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Point
    {
        public static int[] quarters = new int[4];
        public static int total = 0;
        int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            total++;

            if (x > 0 && y > 0) quarters[0]++;
            else if (x < 0 && y > 0) quarters[1]++;
            else if (x < 0 && y < 0) quarters[2]++;
            else if (x > 0 && y < 0) quarters[3]++;
        }

        public void Print() => Console.WriteLine($"Точка: ({x}, {y})");

        public static void PrintStats()
        {
            for (int i = 0; i < 4; i++) Console.WriteLine($"{i + 1} четверть: {quarters[i]}");
            Console.WriteLine($"Всего точек: {total}");
        }
    }
}
