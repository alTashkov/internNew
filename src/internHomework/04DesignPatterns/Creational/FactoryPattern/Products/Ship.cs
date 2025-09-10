using System;

namespace FactoryPattern
{
    class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by sea in a container...");
        }
    }
}
