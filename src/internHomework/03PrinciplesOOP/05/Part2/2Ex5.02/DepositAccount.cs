using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex5._02
{
    class DepositAccount : Account, IDeposit, IWithdraw
    {
        public DepositAccount(Customer customer)
        {
            AccountCustomer = customer;
        }
        public void Withdraw(double amount)
        {
            Balance -= (long)amount;
        }
        public override double CalculateInterestAmount(double numberOfMonths)
        {
            if (!(Balance <= 0 || Balance > 1000))
            {
                InterestRate = 0;
            }
            return InterestRate * numberOfMonths;
        }
        public void Deposit(double amount)
        {
            Balance += (long)amount;
        }
    }
}
