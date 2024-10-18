using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._6._Observer
{
    public interface IObserver
    {
        void Update(float temperature);
    }
}
