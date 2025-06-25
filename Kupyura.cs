using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Kupyura
    {
        public string Name { get; set; }
        private int nominal;
        public int Nominal
        {
            get => nominal;
            set => nominal = value > 0 ? value : 1;
        }

        private int count;
        public int Count
        {
            get => count;
            set => count = value >= 0 ? value : 0;
        }

        public Kupyura() { }
        public Kupyura(string name) => Name = name;
        public Kupyura(string name, int nom, int cnt)
        {
            Name = name;
            Nominal = nom;
            Count = cnt;
        }

        public void ChangeCount(int delta) => Count += delta;
        public bool CanPay(int price) => (Nominal * Count) >= price;

        public void Print()
        {
            Console.WriteLine($"Название: {Name}, Номинал: {Nominal}, Кол-во: {Count}");
        }
    }
}
