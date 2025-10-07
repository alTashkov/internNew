namespace _2Ex5._02
{
    class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer)
        {
            AccountCustomer = customer;
        }

        public override double CalculateInterestAmount(double numberOfMonths)
        {
            if (numberOfMonths <= 3 
                && (AccountCustomer.GetType() == typeof(Individual)))
            {
                return 0;
            }
            else if(numberOfMonths <= 2 && (AccountCustomer.GetType() == typeof(Company)))
            {
                return 0;
            }
            return numberOfMonths * InterestRate;
        }

        public void Deposit(double amount)
        {
            Balance += (decimal)amount;
        }
    }
}
