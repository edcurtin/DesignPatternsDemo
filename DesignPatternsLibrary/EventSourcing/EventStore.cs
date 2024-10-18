using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.EventSourcing
{
    // Event store that holds all events for the bank account
    public class EventStore
    {
        private List<Event> _events = new();

        public void SaveEvent(Event eventItem)
        {
            _events.Add(eventItem);
        }

        public List<Event> GetEvents() => _events;

        public void ReplayEvents(BankAccount account)
        {
            foreach (var eventItem in _events)
            {
                eventItem.Apply(account);
            }
        }
    }
}
