using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * Imagine you're developing a text editor that allows users to write and modify text. 
     * You want to implement an undo feature that allows users to revert to a previous state of the text.
    */

    /*Explanation:
     * Memento (EditorMemento):
     * This class stores the state of the Editor (in this case, the content of the text editor).
     * It provides a constructor to set the state and a property to retrieve it.
     * 
     * Originator (Editor):
     * The Editor class represents the object whose state needs to be saved and restored.
     * It has a Save() method that creates a memento containing the current state and a Restore() method that restores the state from a given memento.
     * 
     * Caretaker (EditorHistory):
     * The EditorHistory class is responsible for managing the mementos. It keeps a stack of mementos to allow undo operations.
     * The Save() method saves the current state of the editor, and the Undo() method restores the last saved state.
     * 
     * Client (Program):
     * The client code interacts with the Editor and EditorHistory classes.
     * It demonstrates how to save the state of the editor and perform undo operations.
    */

    // Memento class that stores the state of the Editor
    class EditorMemento
    {
        public string Content { get; private set; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }

    // Originator class that creates and restores states
    class Editor
    {
        public string Content { get; set; }

        public EditorMemento Save()
        {
            return new EditorMemento(Content);
        }

        public void Restore(EditorMemento memento)
        {
            Content = memento.Content;
        }
    }

    // Caretaker class that manages Mementos
    class EditorHistory
    {
        private Stack<EditorMemento> _history = new Stack<EditorMemento>();

        public void Save(Editor editor)
        {
            _history.Push(editor.Save());
        }

        public void Undo(Editor editor)
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                editor.Restore(memento);
            }
        }
    }
}
