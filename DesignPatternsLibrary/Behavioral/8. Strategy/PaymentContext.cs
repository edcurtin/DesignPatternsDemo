using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._8._Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        // Set the strategy dynamically
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        // Execute the strategy
        public void PayAmount(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Payment strategy is not set!");
                return;
            }
            _paymentStrategy.Pay(amount);
        }
    }
}
