using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._9._Template_Method
{
    public class Tea : Beverage
    {
        protected override void BrewOrSteep()
        {
            Console.WriteLine("Steeping tea...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }
    }
}
