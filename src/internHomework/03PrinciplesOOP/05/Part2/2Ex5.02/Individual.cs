using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
