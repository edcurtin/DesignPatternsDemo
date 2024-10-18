using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._11._Chain_Of_Responsibility
{
    public class ConcreteHandlerB : AbstractHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "B")
            {
                Console.WriteLine("Handler B is processing the request.");
            }
            else
            {
                Console.WriteLine("Handler B cannot handle this request. Passing to the next handler.");
                NextHandler?.HandleRequest(request);
            }
        }
    }
}
