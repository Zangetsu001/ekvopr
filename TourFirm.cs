using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class TourFirm
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string INN { get; set; }
        public double Profit { get; set; }

        public TourFirm(string name, int year, string inn, double profit)
        {
            Name = name;
            Year = year;
            INN = inn;
            Profit = profit;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} | Год: {Year} | ИНН: {INN} | Прибыль: {Profit} руб.");
        }
    }
}
