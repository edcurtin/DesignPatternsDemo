
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._4._Mediator
{
    // This request will carry a string name and expects a string result.
    public class GreetingRequest : IRequest<string>
    {
        public string Name { get; set; }
        public GreetingRequest(string name)
        {
            Name = name;
        }
    }
}
