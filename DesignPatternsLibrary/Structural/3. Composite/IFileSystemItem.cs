using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._3._Composite
{
    public interface IFileSystemItem
    {
        string Name { get; }
        void Display(int depth);
    }
}
