namespace DecoratorPattern
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(Coffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return coffee.GetCost() + 2;
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Milk";
        }
    }
}
