using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.EventSourcing
{
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }
        public abstract void Apply(BankAccount account);
    }
}
