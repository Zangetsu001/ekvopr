using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    enum Post
    {
        Manager = 180,
        Developer = 170,
        Analyst = 175,
        Designer = 160,
        Tester = 165
    }

    internal class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return hours > (int)worker;
        }
    }
}
