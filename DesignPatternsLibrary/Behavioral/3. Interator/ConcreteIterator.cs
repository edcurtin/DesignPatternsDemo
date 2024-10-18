using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._3._Interator
{
    // Concrete iterator class
    public class ConcreteIterator : IIterator
    {
        private ConcreteCollection _collection;
        private int _currentIndex = 0;

        public ConcreteIterator(ConcreteCollection collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return _currentIndex < _collection.Count;
        }

        public object Next()
        {
            if (!HasNext())
                throw new InvalidOperationException("No more elements in collection.");

            return _collection[_currentIndex++];
        }
    }
}
