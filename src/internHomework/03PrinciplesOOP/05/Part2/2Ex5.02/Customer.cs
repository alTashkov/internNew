using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex5._02
{
    public abstract class Customer
    {
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

    }
}
