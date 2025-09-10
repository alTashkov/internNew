namespace AdapterPattern
{
    class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is {this.adaptee.GetSpecificRequest()}";
        }
    }
}
