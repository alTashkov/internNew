namespace _2Ex6._01
{
    class Person
    {
        private string name;

        private int? age = null;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int? age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            if (age != null)
            {
                return $"This person's name is {name} and they are {age} years old.";
            }
            return $"This person's name is {name}. Their age is not specified.";
        }
    }
}
