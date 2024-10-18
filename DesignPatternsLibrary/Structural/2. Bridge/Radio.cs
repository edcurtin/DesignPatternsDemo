using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._2._Bridge
{
    public class Radio : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Radio is turned ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Radio is turned OFF");
        }
    }
}
