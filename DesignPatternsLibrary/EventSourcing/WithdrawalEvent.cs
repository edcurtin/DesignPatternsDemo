using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.EventSourcing
{
    // Withdrawal event
    public class WithdrawalEvent : Event
    {
        public decimal Amount { get; private set; }

        public WithdrawalEvent(decimal amount)
        {
            Amount = amount;
            Timestamp = DateTime.UtcNow;
        }

        public override void Apply(BankAccount account)
        {
            account.Balance -= Amount;
        }

        public override string ToString()
        {
            return $"Withdrew {Amount:C} on {Timestamp}";
        }
    }
}
