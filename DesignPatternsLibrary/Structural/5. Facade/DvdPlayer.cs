using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._5._Facade
{
    public class DVDPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD Player is turned ON.");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player is turned OFF.");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"DVD Player is playing '{movie}'.");
        }

        public void Stop()
        {
            Console.WriteLine("DVD Player has stopped playing.");
        }
    }
}
