namespace VisitorPattern
{
    public class Fruit : IItem
    {
        public double PricePerKg { get; set; }

        public Fruit(double price)
        {
            PricePerKg = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
