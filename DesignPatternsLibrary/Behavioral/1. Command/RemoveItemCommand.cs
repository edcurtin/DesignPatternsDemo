using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._1._Command
{
    public class RemoveItemCommand : ICommand
    {
        private readonly List<string> _items;
        private readonly string _item;

        public RemoveItemCommand(List<string> items, string item)
        {
            _items = items;
            _item = item;
        }

        public void Execute()
        {
            if (_items.Remove(_item))
            {
                Console.WriteLine($"Removed: {_item}");
            }
            else
            {
                Console.WriteLine($"Item not found: {_item}");
            }
        }
    }
}
