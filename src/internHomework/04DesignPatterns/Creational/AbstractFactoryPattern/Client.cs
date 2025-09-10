using System;

namespace AbstractFactoryPattern
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Creating factory 1...");
            ClientMethod(new ConcreteFactory1());

            Console.WriteLine("Creating factory 2...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
