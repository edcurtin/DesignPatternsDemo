using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._9._Template_Method
{
    // Abstract base class
    public abstract class Beverage
    {
        // Template method - final method, cannot be overridden
        public void PrepareRecipe()
        {
            BoilWater();
            BrewOrSteep();
            PourInCup();
            AddCondiments();
        }

        // Common step for all beverages
        private void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        // Common step for all beverages
        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup...");
        }

        // Steps that subclasses will override
        protected abstract void BrewOrSteep();
        protected abstract void AddCondiments();
    }
}
