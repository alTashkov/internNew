using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._02
{
    class Student : Human
    {
        private string firstName;
        private string lastName;
        private int grade;
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

        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Grade must be in the range 2-6");
                }
                grade = value;
            }
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(string firstName, string lastName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            this.Grade = grade;
        }

    }
}
