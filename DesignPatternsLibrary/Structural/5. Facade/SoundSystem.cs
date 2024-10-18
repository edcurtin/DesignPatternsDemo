using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._5._Facade
{
    public class SoundSystem
    {
        public void On()
        {
            Console.WriteLine("Sound System is turned ON.");
        }

        public void Off()
        {
            Console.WriteLine("Sound System is turned OFF.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Sound System volume set to {level}.");
        }
    }
}
