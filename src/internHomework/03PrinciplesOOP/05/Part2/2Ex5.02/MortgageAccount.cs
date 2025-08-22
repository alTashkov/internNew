using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex5._02
{
    class MortgageAccount : Account, IWithdraw
    {
        public MortgageAccount(Customer customer)
        {
            AccountCustomer = customer;
        }
        public override double CalculateInterestAmount(double numberOfMonths)
        {
            if (numberOfMonths <= 6 && (AccountCustomer.GetType() == typeof(Individual)))
            {
                InterestRate = 0;
            }
            else if (numberOfMonths <= 12 && (AccountCustomer.GetType() == typeof(Company)))
            {
                InterestRate = 0.5;
            }
            return numberOfMonths * InterestRate;
        }
        public void Withdraw(double amount)
        {
            Balance -= (long)amount;
        }
    }
}
