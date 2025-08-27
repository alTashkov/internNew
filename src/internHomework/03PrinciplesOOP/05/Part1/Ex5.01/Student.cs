namespace School
{
    class Student : People
    {
        private string classIdentifier;

        public string ClassIdentifier
        {
            get { return classIdentifier; }
            private set
            {
                classIdentifier = value;
            }
        }

        public Student(string name, string classIdentifier, string comments)
        {
            Name = name;
            this.classIdentifier = classIdentifier;
            AddComments(comments);
        }
    }
}
