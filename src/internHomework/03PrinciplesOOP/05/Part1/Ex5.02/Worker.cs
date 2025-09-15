using System;
namespace Ex5._02
{
    class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public decimal WeekSalary { 
            get
            {
                if (weekSalary < 0)
                {
                    throw new ArgumentException("Invalid amount for the salary (cannot be less than 0)!");
                }
                return weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid amount for the salary (cannot be less than 0)!");
                }
                weekSalary = value;
            }
        }
        public double WorkHoursPerDay {  
            get
            {
                if (workHoursPerDay < 0 || workHoursPerDay > 24)
                {
                    throw new ArgumentException("Invalid amount of hours per day!");
                }
                return workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid amount of hours per day!");
                }
                workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
        {
            FirstName = firstName;
            LastName = lastName;
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            return (decimal)((double)WeekSalary / (5 * WorkHoursPerDay));
        }
    }
}
