using System.Collections.Generic;

namespace VisitorPattern
{
    internal class Program
    {
        //visitor lets you add new opeartions to
        //a group of objects
        //without changing their classes
        //the visitor does the work, the objects accept it.
        //It lets us separate algorithms from the objects on which they operate.
        static void Main(string[] args)
        {
            List<IItem> items = new List<IItem>
            {
                new Book(20),
                new Fruit(5)
            };

            IVisitor visitor = new PriceVisitor();
            foreach (var item in items)
            {
                item.Accept(visitor);
            }
        }
    }
}
