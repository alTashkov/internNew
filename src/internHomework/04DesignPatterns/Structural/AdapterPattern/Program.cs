using System;

namespace AdapterPattern
{
    internal class Program
    {
        //Adapater lets incompatible interfaces to work together.
        //acts as a mediator
        //useful for reusing legacy (old/already existing)
        //code with a new system or when
        //changing a system to a new data type.
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine(target.GetRequest());
            Console.ReadLine();
        }
    }
}
