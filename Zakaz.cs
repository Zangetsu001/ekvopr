using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Zakaz
    {
        public string Fam { get; set; }
        public int Size { get; set; }
        public string Comfort { get; set; }

        public Zakaz() { }
        public Zakaz(string fam) => Fam = fam;
        public Zakaz(string fam, int size) : this(fam) => Size = size;
        public Zakaz(string fam, int size, string comfort) : this(fam, size) => Comfort = comfort;

        public void Show()
        {
            Console.WriteLine($"Фамилия: {Fam}, Мест: {Size}, Комфорт: {Comfort}");
        }
    }
}
