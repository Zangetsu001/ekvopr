using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Russian:Human
    {
        public Russian(string name) : base(name) { }
        public override void SayHello() => Console.WriteLine($"Привет, я {Name}");
    }
}
