using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._3._Interator
{
    // Concrete collection class
    public class ConcreteCollection : IEnumerableCollection
    {
        private ArrayList _items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count => _items.Count;

        // Indexer to get the item at a specific position
        public object? this[int index]
        {
            
            get
            {
                 return _items[index];
            }
        }

        // Add an item to the collection
        public void AddItem(object item)
        {
            _items.Add(item);
        }
    }
}
