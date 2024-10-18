using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._3._Composite
{
    public class File : IFileSystemItem
    {
        public string Name { get; }

        public File(string name)
        {
            Name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
