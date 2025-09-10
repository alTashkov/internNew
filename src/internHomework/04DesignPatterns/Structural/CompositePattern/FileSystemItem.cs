namespace CompositePattern
{
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public abstract void Display(int indent = 0);
    }
}
