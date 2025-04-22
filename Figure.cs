using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Figure
    {
        private Point[] points;
        private string name;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
            name = $"{p1.Name}{p2.Name}{p3.Name}";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
            name = $"{p1.Name}{p2.Name}{p3.Name}{p4.Name}";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
            name = $"{p1.Name}{p2.Name}{p3.Name}{p4.Name}{p5.Name}";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                Point next = points[(i + 1) % points.Length];
                perimeter += LengthSide(current, next);
            }

            Console.WriteLine($"Название фигуры: {name}");
            Console.WriteLine($"Периметр фигуры: {perimeter:F2}");
        }
    }
}
