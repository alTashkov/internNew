using System;

namespace CompositePattern
{
    public class File : FileSystemItem
    {
        public File(string name)
        {
            Name = name;
        }
        public override void Display(int indent)
        {
            Console.WriteLine(new string('-',indent) + Name);
        }
    }
}
