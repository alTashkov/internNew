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
        private Specialties specialty;
        private Universities university;
        private Faculties faculty;

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

        public Specialties Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        public Universities Univeristy
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

        public Faculties Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress, string phoneNumber, string email, string course, string specialty, string university, string faculty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            SSN = ssn;
            this.permanentAddress = permanentAddress;
            PhoneNumber = phoneNumber;
            Email = email;
            Course = course;
            Specialty = Enum.Parse<Specialties>(specialty);
            Univeristy = Enum.Parse<Universities>(university);
            Faculty = Enum.Parse<Faculties>(faculty);

        }

        public object Clone()
        {
            return MemberwiseClone();
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
            if (obj == null) return false;

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
            if (ReferenceEquals(student1, student2)) return true;
            if (student1 is null || student2 is null) return false;

            if (student1.Equals(student2))
            {
                return true;
            }

            return false;
         }

        public static bool operator != (Student student1, Student student2)
        {
            return !(student1 == student2); 
        }

    }
}
