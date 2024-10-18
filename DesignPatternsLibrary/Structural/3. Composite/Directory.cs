using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._3._Composite
{
    public class Directory : IFileSystemItem
    {
        public string Name { get; }
        private List<IFileSystemItem> _items = new List<IFileSystemItem>();

        public Directory(string name)
        {
            Name = name;
        }

        public void Add(IFileSystemItem item)
        {
            _items.Add(item);
        }

        public void Remove(IFileSystemItem item)
        {
            _items.Remove(item);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach (var item in _items)
            {
                item.Display(depth + 2);
            }
        }
    }
}
