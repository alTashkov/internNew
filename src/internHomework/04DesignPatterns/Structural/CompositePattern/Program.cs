namespace CompositePattern
{
    internal class Program
    {
        //Composite allows you to work with single
        //objects and collections in the same way,
        //so you don’t have to care whether
        //you’re handling an individual item or a group.
        static void Main(string[] args)
        {
            Folder root = new Folder("Root");
            root.Add(new File("File1.txt"));
            root.Add(new File("File2.txt"));

            Folder subFolder = new Folder("SubFolder");
            subFolder.Add(new File("File3.txt"));
            root.Add(subFolder);

            root.Display(0);
        }
    }
}
