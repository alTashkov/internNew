namespace School
{
    internal abstract class People : ICommentable
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
