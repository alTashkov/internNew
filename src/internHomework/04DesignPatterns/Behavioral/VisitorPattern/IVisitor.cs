namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(Book book);
        void Visit(Fruit fruit);
    }
}
