using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Plane:Vehicle
    {
        public double Height { get; set; }
        public int Passengers { get; set; }
        public Plane(double x, double y, double price, double speed, double years, double height, int passengers)
            :base(x,y,price,speed,years)
        {
            Height = height;
            Passengers = passengers;
        }
        public override void ShowInfo(int index)
        {
            Console.WriteLine("Самолет");
            Console.WriteLine($"Координата X: {X}");
            Console.WriteLine($"Координата Y: {Y}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Количество пассажиров: {Passengers}");
        }
    }
}
