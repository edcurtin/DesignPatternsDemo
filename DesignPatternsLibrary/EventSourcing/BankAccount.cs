using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.EventSourcing
{
    // Aggregate root (Bank Account)
    public class BankAccount
    {
        public Guid AccountId { get; private set; }
        public decimal Balance { get; set; }

        public BankAccount()
        {
            AccountId = Guid.NewGuid();
            Balance = 0;
        }

        public void LoadFromHistory(List<Event> events)
        {
            foreach (var e in events)
            {
                e.Apply(this);
            }
        }

        public override string ToString()
        {
            return $"Bank Account {AccountId}, Balance: {Balance:C}";
        }
    }
}
