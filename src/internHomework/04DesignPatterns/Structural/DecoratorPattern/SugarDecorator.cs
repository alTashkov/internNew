namespace DecoratorPattern
{
    internal class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(Coffee coffee) : base(coffee) {}

        public override double GetCost()
        {
            return coffee.GetCost() + 1;
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Sugar";
        }
    }
}
