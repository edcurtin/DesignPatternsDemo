using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._7._State
{
    public class ClosedState : IState
    {
        public void Handle(Ticket ticket)
        {
            Console.WriteLine("Ticket is already closed. No further action can be taken.");
        }
    }
}
