using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex5._02
{
    public abstract class Account
    {
        private Customer _customer;
        private long balance;
        private double interestRate = 1;

        public long Balance
        {
            get { return balance; }
            set
            {
                balance = value;
            }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set
            {
                interestRate = value;
            }
        }

        public Customer AccountCustomer
        {
            get { return _customer; }
            set
            {
                _customer = value;
            }
        }
        public abstract double CalculateInterestAmount(double numberOfMonths);
    }
}
