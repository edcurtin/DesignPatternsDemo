using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._7._State
{
    public class Ticket
    {
        private IState _state;

        public Ticket()
        {
            _state = new NewState(); // Initial state
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Next()
        {
            _state.Handle(this);
        }
    }
}
