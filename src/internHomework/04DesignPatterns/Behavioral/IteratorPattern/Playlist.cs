using System.Collections.Generic;

namespace IteratorPattern
{
    public class Playlist : IPlaylistAggreagate
    {
        private List<Song> songs = new List<Song>();
        public IIterator<Song> CreateIterator()
        {
            return new PlaylistIterator(this);
        }

        public int Count { get { return songs.Count; } }

        public Song this[int index]
        {
            get { return songs[index]; }
            set { songs.Insert(index, value); }
        }

        public void Add (Song song)
        {
            songs.Add(song);
        }
    }
}
