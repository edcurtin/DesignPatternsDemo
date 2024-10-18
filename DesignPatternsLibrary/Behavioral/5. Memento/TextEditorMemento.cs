using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._5._Memento
{
    public class TextEditorMemento
    {
        public string State { get; }

        public TextEditorMemento(string state)
        {
            State = state;
        }
    }
}
