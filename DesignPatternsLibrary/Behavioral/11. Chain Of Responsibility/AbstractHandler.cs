using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._11._Chain_Of_Responsibility
{
    public abstract class AbstractHandler
    {
        protected AbstractHandler? NextHandler;

        public void SetNext(AbstractHandler handler)
        {
            NextHandler = handler;
        }

        public abstract void HandleRequest(string request);
    }
}
