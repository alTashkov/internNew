using System;

namespace DecoratorPattern
{
    //Decorator dynamically adds behaviour or responsibilities
    //to an object without modifying the class.
    //This supports the open/closed principle
    //Its useful for optional features.
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee newCoffee = new SimpleCoffee();

            newCoffee = new MilkDecorator(newCoffee);
            newCoffee = new SugarDecorator(newCoffee);

            Console.WriteLine(newCoffee.GetDescription());
            Console.WriteLine(newCoffee.GetCost());
        }
    }
}
