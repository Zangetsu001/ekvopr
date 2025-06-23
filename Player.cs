using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    // Класс, реализующий оба интерфейса
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Playing...");
        }

        public void Record()
        {
            Console.WriteLine("Recording...");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Paused...");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Paused...");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stopped...");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stopped...");
        }
    }
}

