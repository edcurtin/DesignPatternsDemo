using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._9._Template_Method
{
    // Concrete class for Coffee
    public class Coffee : Beverage
    {
        protected override void BrewOrSteep()
        {
            Console.WriteLine("Brewing coffee...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk...");
        }
    }
}
