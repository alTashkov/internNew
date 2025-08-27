namespace _2Ex5._02
{
    class Company : Customer
    {
        private string customerName;

        public override string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public Company(string companyName) 
        {
            customerName = companyName;
        }
    }
}
