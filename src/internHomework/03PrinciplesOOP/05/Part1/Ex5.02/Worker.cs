using System;
namespace Ex5._02
{
    class Worker : Human
    {
        private string firstName;
        private string lastName;

        private double weekSalary;
        private double workHoursPerDay;

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

        public double WeekSalary { 
            get
            {
                return weekSalary;
            }
            set
            {
                weekSalary = value;
            }
        }
        public double WorkHoursPerDay {  
            get
            {
                return workHoursPerDay;
            }
            set
            {
                workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return weekSalary / (5 * workHoursPerDay);
        }
    }
}
