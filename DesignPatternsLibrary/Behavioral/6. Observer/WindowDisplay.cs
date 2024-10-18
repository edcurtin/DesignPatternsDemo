using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._6._Observer
{
    public class WindowDisplay : IObserver
    {
        private ISubject weatherStation;

        public WindowDisplay(ISubject weatherStation)
        {
            this.weatherStation = weatherStation;
            weatherStation.RegisterObserver(this);
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"WindowDisplay: Temperature updated to {temperature}°C");
        }
    }
}
