using System;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playlist = new Playlist();

            playlist.Add(new Song {Title = "Imagine", Artist = "John Lennon" });
            playlist.Add(new Song {Title = "Hotel California", Artist = "Eagles" });
            playlist.Add(new Song {Title = "What I've Done", Artist = "Linkin Park" });

            IIterator<Song> iterator = playlist.CreateIterator();

            Console.WriteLine("Playlist: ");

            for (Song song = iterator.First(); !iterator.IsDone; song = iterator.Next())
            {
                Console.WriteLine(song);
            }

        }
    }
}
