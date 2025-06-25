using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Disk : IShape
    {
        double r;
        public Disk(double r) { this.r = r; }
        public double Perimeter() => 2 * Math.PI * r;
        public double Area() => Math.PI * r * r;
        public override string ToString() => $"Круг: r={r}";
    }
}
