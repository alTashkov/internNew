namespace IteratorPattern
{
    class PlaylistIterator : IIterator<Song>
    {
        private Playlist playlist;

        private int current = 0;

        public PlaylistIterator(Playlist playlist)
        {
            this.playlist = playlist;
        }

        public bool IsDone
        {
            get
            {
                return (current >= playlist.Count);
            }
        }

        public Song CurrentItem
        {
            get
            {
                return playlist[current];
            }
        }

        public Song First()
        {
            current = 0;

            return playlist[current];
        }

        public Song Next()
        {
            current++;
            
            if (!IsDone)
            {
                return playlist[current];
            }

            return null;
        }
    }
}
