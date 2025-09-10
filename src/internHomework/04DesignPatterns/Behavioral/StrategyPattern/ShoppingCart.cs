using System;

namespace StrategyPattern
{
    public class ShoppingCart
    {
        private IStrategy _strategy;

        public void SetPaymentStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Checkout(decimal amount)
        {
            if (_strategy == null)
            {
                Console.WriteLine("No payment method selected.");
                return;
            }

            _strategy.Pay(amount);
        }
    }
}
