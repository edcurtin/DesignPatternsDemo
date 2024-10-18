using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._4._Decorator
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 5.0; // Base price for coffee
        }
    }
}
