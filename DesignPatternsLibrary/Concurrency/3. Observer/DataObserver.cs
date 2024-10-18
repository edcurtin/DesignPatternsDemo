using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Concurrency._3._Observer
{
    public class DataObserver : IObserver<int>
    {
        private readonly string _name;
        public DataObserver(string name)
        {
            _name = name;
        }

        public void OnCompleted()
        {
            Console.WriteLine($"{_name}: Sensor stopped sending data.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{_name}: Error occurred.");
        }

        public void OnNext(int value)
        {
            Console.WriteLine($"{_name}: Received data {value}");
        }
    }
}
