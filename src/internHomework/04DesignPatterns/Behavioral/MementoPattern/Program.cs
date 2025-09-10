using System;

namespace MementoPattern
{
    //client

    //Captures and restores and object's internal state without
    //exposing details of implementation
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            History history = new History();

            doc.Content = "Version 1";
            history.Push(doc.Save());

            doc.Content = "Version 2";
            history.Push(doc.Save());

            doc.Content = "Version 3";
            Console.WriteLine(doc.Content); // v 3

            doc.Restore(history.Pop());
            Console.WriteLine(doc.Content); // v 2

            doc.Restore(history.Pop());
            Console.WriteLine(doc.Content);// v 1
        }
    }
}
