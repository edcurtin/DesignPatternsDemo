using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._2._Bridge
{
    public abstract class RemoteControl
    {
        protected IDevice _device;

        protected RemoteControl(IDevice device)
        {
            _device = device;
        }

        public abstract void PressOnButton();
        public abstract void PressOffButton();
    }
}
