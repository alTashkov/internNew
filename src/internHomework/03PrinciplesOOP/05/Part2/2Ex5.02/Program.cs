using System;
using System.Collections.Generic;

namespace _2Ex5._02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            Individual individual = new Individual("Alexandar","Tashkov");
            Company company1 = new Company("Technopolis");
            Individual individual2 = new Individual("Petar", "Petrov");

            DepositAccount depositAccount = new DepositAccount(individual);
            LoanAccount loanAccount = new LoanAccount(company1);
            MortgageAccount mortgageAccount = new MortgageAccount(company1);

            accounts.Add(depositAccount);
            accounts.Add(loanAccount);
            accounts.Add(mortgageAccount);

            Bank bank = new Bank(accounts);

            foreach (Account account in accounts)
            {
                if (account != null)
                {
                    Console.WriteLine(account.GetType().Name + " of " + account.AccountCustomer.CustomerName + "'s interest rate: " +
                   "" + "$ " + account.CalculateInterestAmount(8));
                }
            }
        }
    }
}
