using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new ExcellentPupil("Иванов");
            Pupil p2 = new GoodPupil("Петров");
            Pupil p3 = new BadPupil("Сидоров");

            ClassRoom classRoom = new ClassRoom(p1, p2, p3);
            classRoom.ShowActivities();


            Console.ReadKey();
        }
    }
}
