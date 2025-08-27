using System.Collections.Generic;

namespace _2Ex5._02
{
    class Bank
    {
        private List<Account> accounts;

        public Bank(List<Account> accounts)
        {
            this.accounts = accounts;
        }

        public List<Account> Accounts { 
            get { return accounts; } 
            set { accounts = value; } 
        }
    }
}
