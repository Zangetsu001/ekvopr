using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    abstract class Vehicle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public double Year { get; set; }
        public Vehicle(double x, double y, double price, double speed, double year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }
        public abstract void ShowInfo(int index);
    }
}
