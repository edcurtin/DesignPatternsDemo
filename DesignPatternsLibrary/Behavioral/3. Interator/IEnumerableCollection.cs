using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._3._Interator
{
    // Collection interface
    public interface IEnumerableCollection
    {
        IIterator CreateIterator();   // Create an iterator for the collection
    }
}
