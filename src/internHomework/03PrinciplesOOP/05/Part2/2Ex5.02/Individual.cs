namespace _2Ex5._02
{
    class Individual : Customer
    {
        public Individual(string firstName, string lastName) 
        {
            CustomerName = firstName + " " + lastName;
        }
        
    }
}
