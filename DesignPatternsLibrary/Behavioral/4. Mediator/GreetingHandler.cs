using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._4._Mediator
{
    // Handler for GreetingRequest, implements IRequestHandler interface.
    public class GreetingHandler : IRequestHandler<GreetingRequest, string>
    {
        public Task<string> Handle(GreetingRequest request, CancellationToken cancellationToken)
        {
            // Logic to handle the request and return a response.
            return Task.FromResult($"Hello, {request.Name}!");
        }
    }
}
