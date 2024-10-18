using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._6._Observer
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers;
        private float temperature;

        public WeatherStation()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }

        public void SetTemperature(float newTemperature)
        {
            Console.WriteLine($"WeatherStation: Setting temperature to {newTemperature}°C");
            this.temperature = newTemperature;
            NotifyObservers();
        }
    }
}
