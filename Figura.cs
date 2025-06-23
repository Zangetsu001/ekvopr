using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Figura
    {
        public void ShowArea(double side)
        {
            Console.WriteLine("Фигура: Квадрат");
            Console.WriteLine("Площадь: " + (side * side));
        }

       
        public void ShowArea(double length, double width)
        {
            Console.WriteLine("Фигура: Прямоугольник");
            Console.WriteLine("Площадь: " + (length * width));
        }

        
        public void ShowArea(double base1, double base2, double height)
        {
            Console.WriteLine("Фигура: Трапеция");
            Console.WriteLine("Площадь: " + ((base1 + base2) * height / 2));
        }
    }
}
