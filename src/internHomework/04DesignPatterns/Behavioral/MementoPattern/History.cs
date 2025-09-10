using System.Collections.Generic;

namespace MementoPattern
{
    //caretaker
    public class History
    {
        private Stack<DocumentMemento> states = new Stack<DocumentMemento>();

        public void Push(DocumentMemento memento)
        {
            states.Push(memento);
        }

        public DocumentMemento Pop()
        {
            return states.Pop();
        }
    }
}
