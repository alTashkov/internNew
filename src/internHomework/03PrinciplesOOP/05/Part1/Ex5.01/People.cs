namespace School
{
    abstract class People : IHaveComments
    {
        private string name;

        private string comments;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Comments
        {
            get { return comments; }
        }

        public void AddComments(string comments) 
        {
            this.comments = comments;
        }

    }
}
