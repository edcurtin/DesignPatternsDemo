using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._8._Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
