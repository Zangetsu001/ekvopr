using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Computer
    {
        public string Model { get; set; }

        private int ram;
        public int RAM
        {
            get => ram;
            set => ram = (value >= 2 && value <= 32) ? value : throw new ArgumentException("RAM от 2 до 32");
        }

        private int hdd;
        public int HDD
        {
            get => hdd;
            set => hdd = (value >= 200 && value <= 2000) ? value : throw new ArgumentException("HDD от 200 до 2000");
        }

        public double GetCost() => RAM * 10 + HDD * 0.5;
    }
}
