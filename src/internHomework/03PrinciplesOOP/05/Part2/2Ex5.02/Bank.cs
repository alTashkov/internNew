using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
