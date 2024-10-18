using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Concurrency._3._Observer
{
    public class Unsubscriber : IDisposable
    {
        private readonly ConcurrentBag<IObserver<int>> _observers;
        private readonly IObserver<int> _observer;

        public Unsubscriber(ConcurrentBag<IObserver<int>> observers, IObserver<int> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                // Not possible to remove from ConcurrentBag, but we can stop observing updates.
            }
        }
    }
}
