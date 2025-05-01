using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Ship:Vehicle
    {
        public int Passengers { get; set; }
        public string Port {  get; set; }
        public Ship(double x, double y, double price, double speed, double years, int passengers, string port)
            :base(x, y, price, speed, years)
        {
            Passengers = passengers;
            Port = port;
        }
        public override void ShowInfo(int index)
        {
            Console.WriteLine("Корабль");
            Console.WriteLine($"Координата X: {X}");
            Console.WriteLine($"Координата Y: {Y}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Количество пассажиров: {Passengers}");
            Console.WriteLine($"Порт приписки: {Port}");
        }
    }
}
