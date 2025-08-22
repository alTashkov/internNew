using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex6._01
{
    class Student : ICloneable
    {
        private string firstName;
        private string middleName;
        private string lastName;

        private string ssn;

        private string permanentAddress;

        private string phoneNumber;
        private string email;

        private string course;
        private string specialty;
        private string university;
        private string faculty;

        public string Name
        {
            get
            {
                return firstName + " " + middleName + " " + lastName;
            }
        }

        public string SSN
        {
            get { return ssn; }
            set
            {
                ssn = value;
            }
        }

        public string PermanentAddress
        {
            get { return permanentAddress; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        public string University
        {
            get { return university; }
            set => university = value;
        }

        public string Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress, string phoneNumber, string email, string course, string specialty, string university, string faculty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.permanentAddress = permanentAddress;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.faculty = faculty;
            this.ssn = ssn;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.specialty = specialty;
            this.university = university;
            this.course = course;
            this.faculty = faculty;
        }

        public object Clone()
        {
            return new Student(this.firstName, this.middleName, this.lastName, this.ssn, this.permanentAddress, this.phoneNumber, this.email, this.course, this.specialty, this.university, this.faculty);
        }

        public override string ToString()
        {
            return $"{Name}'s information: \nSSN: {ssn}\nUniveristy: {university}\nFaculty: {faculty}\nCourse: {course}\nSpecialty: {specialty}" +
                $"\nPhone number: {phoneNumber}\nEmail: {email}\nAddress: {permanentAddress}\n";
        }

        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Student other)
            {
                if (SSN == other.SSN)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator == (Student student1, Student student2){
            if (student1.Equals(student2))
            {
                return true;
            }
            return false;
         }

        public static bool operator != (Student student1, Student student2)
        {
            if (!(student1.Equals(student2)))
            {
                return true;
            }
            return false;
        }

    }
}
