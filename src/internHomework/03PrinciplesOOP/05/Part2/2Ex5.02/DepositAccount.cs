namespace _2Ex5._02
{
    class DepositAccount : Account, IDeposit, IWithdraw
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
            set { customer = value; }
        }

        public DepositAccount(Customer customer)
        {
            this.customer = customer;
        }
        public void Withdraw(double amount)
        {
            balance -= (long)amount;
        }
        public override double CalculateInterestAmount(double numberOfMonths)
        {
            if (!(Balance <= 0 || Balance > 1000))
            {
                interestRate = 0;
            }
            return interestRate * numberOfMonths;
        }
        public void Deposit(double amount)
        {
            balance += (long)amount;
        }
    }
}
