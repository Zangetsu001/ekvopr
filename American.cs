using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp42
{
    internal class American:Human
    {
        public American(string name) : base(name) { }
        public override void SayHello() => Console.WriteLine($"Hi, I'm {Name}");
    }
}
