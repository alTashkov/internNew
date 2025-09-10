namespace MementoPattern
{
    //memento
    public class DocumentMemento
    {
        public string Content
        {
            get;
            private set;
        }

        public DocumentMemento(string content)
        {
            Content = content;
        }
    }
}
