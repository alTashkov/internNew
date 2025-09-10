namespace IteratorPattern
{
    public interface IPlaylistAggreagate
    {
        IIterator<Song> CreateIterator();
    }
}
