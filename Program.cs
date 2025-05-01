using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer[] printers = new Printer[]
        {
            new Printer(),
            new RedPrinter(),
            new YellowPrinter(),
            new GreenPrinter(),
        };

            
            for (int i = 0; i < printers.Length; i++)
            {
               
                Printer printer = (Printer)printers[i];
                printer.Print($"Сообщение от {printer.GetType().Name}");
            }

     
            Console.ReadKey();
        }
    }
}
