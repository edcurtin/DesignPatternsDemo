using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._11._Chain_Of_Responsibility
{
    public class Request
    {
        public string Type { get; }

        public Request(string type)
        {
            Type = type;
        }
    }
}
