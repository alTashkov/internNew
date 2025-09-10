namespace MementoPattern
{
    //originator
    public class Document
    {
        public string Content {  get; set; }

        public DocumentMemento Save()
        {
            return new DocumentMemento(Content);
        }

        public void Restore(DocumentMemento memento)
        {
            Content = memento.Content;
        }
    }
}
