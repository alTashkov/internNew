namespace School
{
    class Discipline : IHaveComments
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
            set {
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
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }

        public void AddComments(string comments)
        {
            this.comments = comments;
        }
    }
}
