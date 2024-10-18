using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._2._Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public override void PressOnButton()
        {
            _device.TurnOn();
        }

        public override void PressOffButton()
        {
            _device.TurnOff();
        }
    }
}
