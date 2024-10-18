using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._7._Proxy
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }

            // Add additional behavior here (e.g., logging, access control, etc.)
            Console.WriteLine("Proxy: Logging request before forwarding to RealSubject.");

            _realSubject.Request();

            // You could add more behavior after the request is processed.
            Console.WriteLine("Proxy: Request completed.");
        }
    }
}
