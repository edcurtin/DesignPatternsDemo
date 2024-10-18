using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._5._Facade
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is turned ON.");
        }

        public void Off()
        {
            Console.WriteLine("Projector is turned OFF.");
        }

        public void SetInput(string input)
        {
            Console.WriteLine($"Projector input set to {input}.");
        }
    }
}
