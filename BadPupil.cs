using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class BadPupil:Pupil
    {
        public BadPupil(string lastName) : base(lastName) { }
        public override void Study()
        {
            Console.WriteLine($"{LastName} учится плохо!");
        }

        public override void Read()
        {
            Console.WriteLine($"{LastName} читает очень медленно!");
        }

        public override void Write()
        {
            Console.WriteLine($"{LastName} пишет с большим количеством ошибок!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{LastName} отдыхает, играя в компьютерные игры!");
        }
    }
}
