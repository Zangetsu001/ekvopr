using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            // Работа как IPlayable
            IPlayable playable = player;
            playable.Play();
            playable.Pause();
            playable.Stop();

            Console.WriteLine();

            // Работа как IRecodable
            IRecodable recodable = player;
            recodable.Record();
            recodable.Pause();
            recodable.Stop();

            Console.ReadLine();
        }
    }
    
}
