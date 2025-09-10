using System;

namespace StrategyPattern
{
    public class CreditCardPayment : IStrategy
    {
        private string _cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit card {_cardNumber}");
        }
    }
}
