using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class GoodPupil:Pupil
    {
        public GoodPupil(string lastName) : base(lastName) { }

        public override void Study()
        {
            Console.WriteLine($"{LastName} учится отлично!");
        }

        public override void Read()
        {
            Console.WriteLine($"{LastName} читает очень быстро!");
        }

        public override void Write()
        {
            Console.WriteLine($"{LastName} пишет без ошибок!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{LastName} отдыхает, играя в шахматы!");
        }
    }
}
