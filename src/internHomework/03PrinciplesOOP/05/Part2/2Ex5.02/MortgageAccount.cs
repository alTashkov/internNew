namespace _2Ex5._02
{
    class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer)
        {
            AccountCustomer = customer;
        }

        public override double CalculateInterestAmount(double numberOfMonths)
        {
            if (numberOfMonths <= 6 && (AccountCustomer.GetType() == typeof(Individual)))
            {
                return 0;
            }
            else if (numberOfMonths <= 12 && (AccountCustomer.GetType() == typeof(Company)))
            {
                return 0.5;
            }
            return numberOfMonths * InterestRate;
        }
        public void Deposit(double amount)
        {
            Balance += (decimal)amount;
        }
    }
}
