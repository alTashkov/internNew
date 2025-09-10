using System;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton instance = Singleton.getInstance();

            Singleton instance2 = Singleton.getInstance();

            Console.Write(ReferenceEquals(instance,instance2));//singleton works//I get the same reference for both objects.
        }
    }
}
