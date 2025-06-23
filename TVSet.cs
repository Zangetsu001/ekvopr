using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class TVSet:ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is now ON.");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is now OFF.");
        }
    }
}
