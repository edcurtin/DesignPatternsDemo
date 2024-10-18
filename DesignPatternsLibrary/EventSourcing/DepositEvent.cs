using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.EventSourcing
{
    // Deposit event
    public class DepositEvent : Event
    {
        public decimal Amount { get; private set; }

        public DepositEvent(decimal amount)
        {
            Amount = amount;
            Timestamp = DateTime.UtcNow;
        }

        public override void Apply(BankAccount account)
        {
            account.Balance += Amount;
        }

        public override string ToString()
        {
            return $"Deposited {Amount:C} on {Timestamp}";
        }
    }
}
