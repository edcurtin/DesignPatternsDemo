using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Creational._6._Resolver
{
    public class DoFunkyStuffA : IDoFunkyStuff
    {
        public void Hello(string message)
        {
            Console.WriteLine($"{message}  {nameof(DoFunkyStuffA)}");
        }
    }
}
