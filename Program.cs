using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] people = {
            new Russian("Иван"),
            new American("John"),
            new Turk("Ahmet")
        };

            foreach (var p in people)
                p.SayHello();
        }
    }
}
