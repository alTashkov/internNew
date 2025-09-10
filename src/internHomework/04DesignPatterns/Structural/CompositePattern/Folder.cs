using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Folder : FileSystemItem
    {
        List<FileSystemItem> files = new List<FileSystemItem>();
        public Folder(string name)
        {
            Name = name;
        }

        public void Add (FileSystemItem file)
        {
            files.Add(file);
        }

        public void Remove(FileSystemItem file)
        {
            files.Remove(file);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + Name);
            foreach (var file in files)
            {
                file.Display(indent + 2);
            }
        }
    }
}
