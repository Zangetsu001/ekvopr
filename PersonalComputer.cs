using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class PersonalComputer : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("PC is now ON.");
        }

        public void TurnOff()
        {
            Console.WriteLine("PC is now OFF.");
        }
    }
}
