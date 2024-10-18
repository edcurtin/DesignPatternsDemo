using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._6._Observer
{
    public class PhoneDisplay : IObserver
    {
        private ISubject weatherStation;

        public PhoneDisplay(ISubject weatherStation)
        {
            this.weatherStation = weatherStation;
            weatherStation.RegisterObserver(this);
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"PhoneDisplay: Temperature updated to {temperature}°C");
        }
    }
}
