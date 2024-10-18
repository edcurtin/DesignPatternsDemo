using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._3._Interator
{
    // Iterator interface
    public interface IIterator
    {
        bool HasNext();        // Check if there are more elements to iterate
        object Next();         // Move to the next element
    }
}
