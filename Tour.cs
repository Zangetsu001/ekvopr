using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Tour
    {
        public void TourCalc()
        {
            Console.WriteLine("Минское море. Стоимость: бесплатно");
        }

        public void TourCalc(string country)
        {
            Console.WriteLine($"{country}, 1 день. Стоимость: 50 руб.");
        }

        public void TourCalc(string country, int days)
        {
            Console.WriteLine($"{country}, {days} дн. Стоимость: {50 * days} руб.");
        }
    }
}
