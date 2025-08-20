using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._02
{
    class Worker : Human
    {
        private string firstName;
        private string lastName;

        public override string FirstName
        {
            get { return firstName; }
            set
            {
                if (!(value is string))
                {
                    throw new ArgumentException("The provided first name must be of type string!");
                }
                firstName = value;
            }
        }

        public override string LastName
        {
            get { return lastName; }
            set
            {
                if (!(value is string))
                {
                    throw new ArgumentException("The provided last name must be of type string!");
                }
                lastName = value;
            }
        }

        public double WeekSalary = 0;
        public double WorkHoursPerDay = 0;

        public Worker(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        {
            FirstName = firstName;
            LastName = lastName;
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return WeekSalary / (5 * WorkHoursPerDay);
        }
    }
}
