using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._1._Command
{
    public class AddItemCommand : ICommand
    {
        private readonly List<string> _items;
        private readonly string _item;

        public AddItemCommand(List<string> items, string item)
        {
            _items = items;
            _item = item;
        }

        public void Execute()
        {
            _items.Add(_item);
            Console.WriteLine($"Added: {_item}");
        }
    }
}
