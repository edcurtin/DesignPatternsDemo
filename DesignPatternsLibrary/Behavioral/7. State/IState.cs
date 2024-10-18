using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._7._State
{
    public interface IState
    {
        void Handle(Ticket ticket);
    }
}
