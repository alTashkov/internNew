using System;

namespace VisitorPattern
{
    public class PriceVisitor : IVisitor
    {
        public void Visit(Book book)
        {
            Console.WriteLine($"Book price: $ {book.Price}");
        }

        public void Visit(Fruit fruit)
        {
            Console.WriteLine($"Fruit price: $ {fruit.PricePerKg}");
        }
    }
}
