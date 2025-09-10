namespace DecoratorPattern
{
    public abstract class CoffeeDecorator : Coffee
    {
        protected Coffee coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }
    }
}
