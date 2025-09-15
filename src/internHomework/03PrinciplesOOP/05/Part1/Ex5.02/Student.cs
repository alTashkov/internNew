using System;
using System.Collections.Generic;

namespace Ex5._02
{
    class Student : Human
    {
        private int grade;

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
                    throw new ArgumentException("Grade must be in the range 2-6!");
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
            Grade = grade;
        }
    }
}
