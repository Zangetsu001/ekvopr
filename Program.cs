using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring Interfaces.Example-5***");
            Console.WriteLine("***Concept of multiple inheritance through interface***\n");

            MyClass myClassOb = new MyClass();
            myClassOb.ShowInterfaceA();
            myClassOb.ShowInterfaceB();
            myClassOb.ShowInterfaceC();

            Console.ReadLine();
        }
    }
}
