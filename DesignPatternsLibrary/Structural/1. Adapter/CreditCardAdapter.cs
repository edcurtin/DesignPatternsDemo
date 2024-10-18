using DesignPatternsLibrary.Structural_1.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._1.Adapter
{
    public class CreditCardAdapter : IPaymentProcessor
    {
        private readonly CreditCardPayment _creditCardPayment;

        public CreditCardAdapter(CreditCardPayment creditCardPayment)
        {
            _creditCardPayment = creditCardPayment;
        }

        public void ProcessPayment(decimal amount)
        {
            _creditCardPayment.MakePayment(amount);
        }
    }
}
