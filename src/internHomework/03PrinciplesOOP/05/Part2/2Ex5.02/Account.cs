namespace _2Ex5._02
{
    public abstract class Account
    {
        public abstract long Balance { get; set; }

        public abstract double InterestRate { get; set; }

        public abstract Customer AccountCustomer { get; set; }

        public abstract double CalculateInterestAmount(double numberOfMonths);
    }
}
