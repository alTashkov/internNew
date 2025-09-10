using System;

namespace ProxyPattern
{
    internal class Program
    {
        //Proxy controls the access to an object.
        //It can add extra behaviour - lazy init, access control, 
        //logging, caching
        //Basically acts like a mediator - if you want to acccess the 
        //object you have to get through the proxy.
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("photo.jpg");

            Console.WriteLine("Image created, but not loaded.");

            image.Display();
        }
    }
}
