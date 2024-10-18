using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Concurrency._3._Observer
{
    public class Sensor
    {
        private readonly ConcurrentBag<IObserver<int>> _observers;
        private readonly Random _random = new();
        private bool _running = true;

        public Sensor()
        {
            _observers = new ConcurrentBag<IObserver<int>>();
        }

        // Register an observer
        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        // Method to simulate sensor data generation
        public async Task GenerateDataAsync(CancellationToken token)
        {
            while (_running && !token.IsCancellationRequested)
            {
                int sensorData = _random.Next(1, 100); // Simulate some sensor data.
                Console.WriteLine($"Sensor: Generated data {sensorData}");

                // Notify observers asynchronously
                NotifyObservers(sensorData);

                await Task.Delay(1000); // Simulate time between data generation.
            }
        }

        private void NotifyObservers(int data)
        {
            Parallel.ForEach(_observers, observer =>
            {
                observer.OnNext(data);  // Notify each observer
            });
        }

        public void Stop()
        {
            _running = false;
            foreach (var observer in _observers)
            {
                observer.OnCompleted();
            }
        }
    }
}
