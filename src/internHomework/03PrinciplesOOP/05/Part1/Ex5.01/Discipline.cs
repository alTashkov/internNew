namespace School
{
    internal class Discipline : ICommentable
    {
        private string comments;
        private string name;

        private int numberOfLectures;
        private int numberOfExercises;

        public string Comments {
            get
            {
                return comments;
            }
        }

        public string Name {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            } 
        }

        public int NumberOfLectures {
            get { 
                return numberOfLectures;
            }
            private set {
                numberOfLectures = value;
            }
        }

        public int NumberOfExercises {
            get { 
                return numberOfExercises; 
            } 
            private set {
                numberOfExercises = value; 
            } 
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            Name = name;
            NumberOfLectures = numberOfLectures;
            NumberOfExercises = numberOfExercises;
        }

        public void AddComments(string comments)
        {
            this.comments = comments;
        }
    }
}
