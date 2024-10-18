using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural_1.Adapter
{
    public class PaypalPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} through PayPal.");
        }
    }
}
