using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Tovar
    {
        private string name;
        private int price;
        private int kvo;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Price
        {
            get => price;
            set => price = (value >= 1 && value <= 20) ? value : 1;
        }

        public int Kvo
        {
            get => kvo;
            set => kvo = (value >= 0 && value <= 10) ? value : 0;
        }

        public int GetCost()
        {
            return Price * Kvo;
        }

        public void Show()
        {
            Console.WriteLine($"{Name}: {Kvo} шт по {Price} руб = {GetCost()} руб.");
        }
    }
}
