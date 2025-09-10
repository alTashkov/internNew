namespace IteratorPattern
{
    public class Song
    {
        private string title;

        private string artist;

        public string Title
        {
            get { return title; } 
            set {  title = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public override string ToString()
        {
            return $"{Title} by {Artist}";
        }
    }
}
