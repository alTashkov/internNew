namespace _2Ex5._02
{
    class Individual : Customer
    {
        private string customerName;
        public override string CustomerName 
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public Individual(string firstName, string lastName) 
        {
            customerName = firstName + " " + lastName;
        }
        
    }
}
