namespace VisitorPattern
{
    internal interface IItem
    {
        void Accept(IVisitor visitor);
    }
}
