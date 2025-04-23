using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class ClassRoom
    {
        private List<Pupil> pupils = new List<Pupil>();

   
        public ClassRoom(params Pupil[] pupilArray)
        {
            for (int i = 0; i < pupilArray.Length && i < 4; i++)
            {
                pupils.Add(pupilArray[i]);
            }

         
            while (pupils.Count < 4)
            {
                pupils.Add(new BadPupil("Неизвестный"));
            }
        }

        public void ShowActivities()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
}
