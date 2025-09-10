namespace VisitorPattern
{
    public class Book : IItem
    {
        public double Price { get; set; }   

        public Book(double price)
        {
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
