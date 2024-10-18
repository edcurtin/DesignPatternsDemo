using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._5._Memento
{
    // Caretaker Class (TextEditorHistory)
    public class TextEditorHistory
    {
        private readonly Stack<TextEditorMemento> _history = new Stack<TextEditorMemento>();

        // Save a new Memento
        public void SaveState(TextEditorMemento memento)
        {
            _history.Push(memento);
        }

        // Undo and return the last saved Memento
        public TextEditorMemento Undo()
        {
            if (_history.Count > 0)
            {
                return _history.Pop();
            }
            return null;
        }
    }
}
