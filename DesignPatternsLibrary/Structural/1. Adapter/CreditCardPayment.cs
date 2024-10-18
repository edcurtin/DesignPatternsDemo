using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural_1.Adapter
{
    public class CreditCardPayment
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} through Credit Card.");
        }
    }
}
