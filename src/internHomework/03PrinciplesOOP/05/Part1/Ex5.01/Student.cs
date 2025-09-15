namespace School
{
    internal class Student : People
    {
        private string uniqueClassNumber;

        public string UniqueClassNumber
        {
            get { return uniqueClassNumber; }
            private set
            {
                uniqueClassNumber = value;
            }
        }

        public Student(string name, string uniqueClassNumber, string comments)
        {
            Name = name;
            UniqueClassNumber = uniqueClassNumber;
            AddComments(comments);
        }
    }
}
