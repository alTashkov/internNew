namespace StrategyPattern
{
    //Strategy helps us choose a way of tackling a problem
    //By giving different algorithms to solve it.
    //The client chooses the strategy externally
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            cart.SetPaymentStrategy(new CreditCardPayment("1234-5678-9012-3456 ."));
            cart.Checkout(150.75m);

            cart.SetPaymentStrategy(new PayPalPayment("alextashkov@gmail.com ."));
            cart.Checkout(89.99m);
        }
    }
}
