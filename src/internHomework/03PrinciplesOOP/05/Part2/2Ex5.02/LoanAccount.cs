namespace _2Ex5._02
{
    class LoanAccount : Account, IWithdraw
    {
        private long balance;

        private double interestRate;

        private Customer customer;

        public override long Balance 
        {
            get { return balance; }
            set { balance = value; }
        }

        public override double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public override Customer AccountCustomer
        {
            get { return customer; }
            set {  customer = value; }
        }

        public LoanAccount(Customer customer)
        {
            this.customer = customer;
        }

        public override double CalculateInterestAmount(double numberOfMonths)
        {
            if (numberOfMonths <= 3 && (customer.GetType() == typeof(Individual)))
            {
                interestRate = 0;
            }
            else if(numberOfMonths <= 2 && (customer.GetType() == typeof(Company)))
            {
                interestRate = 0;
            }
            return numberOfMonths * interestRate;
        }

        public void Withdraw(double amount)
        {
            balance -= (long)amount;
        }
    }
}
