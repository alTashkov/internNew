namespace DecoratorPattern
{
    public class SimpleCoffee : Coffee
    {
        public override double GetCost()
        {
            return 5;
        }

        public override string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
