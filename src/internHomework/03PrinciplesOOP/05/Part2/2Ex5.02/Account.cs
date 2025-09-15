namespace _2Ex5._02
{
    public abstract class Account
    {
        public decimal Balance { get; protected set; }

        public double InterestRate { get; protected set; }

        public Customer AccountCustomer { get; protected set; }

        public abstract double CalculateInterestAmount(double numberOfMonths);
    }
}
