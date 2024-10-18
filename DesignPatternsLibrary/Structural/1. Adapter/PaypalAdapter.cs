using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural_1.Adapter
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly PaypalPayment _payPalPayment;

        public PayPalAdapter(PaypalPayment payPalPayment)
        {
            _payPalPayment = payPalPayment;
        }

        public void ProcessPayment(decimal amount)
        {
            _payPalPayment.Pay(amount);
        }
    }
}
