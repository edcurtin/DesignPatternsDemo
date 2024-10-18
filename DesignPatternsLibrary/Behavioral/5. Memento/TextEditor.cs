using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._5._Memento
{
    // Originator Class (TextEditor)
    public class TextEditor
    {
        public string Content { get; set; }

        public TextEditor(string content)
        {
            Content = content;
        }

        // Create a Memento to save the current state
        public TextEditorMemento Save()
        {
            return new TextEditorMemento(Content);
        }

        // Restore the state from a Memento
        public void Restore(TextEditorMemento memento)
        {
            Content = memento.State;
        }

        public void ShowContent()
        {
            Console.WriteLine("Current Content: " + Content);
        }
    }
}
