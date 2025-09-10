using System;

namespace StrategyPattern
{
    public class PayPalPayment : IStrategy
    {
        private string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal with email {_email}");
        }
    }
}
