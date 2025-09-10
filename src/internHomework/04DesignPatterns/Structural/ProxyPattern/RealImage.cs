using System;

namespace ProxyPattern
{
    public class RealImage : IImage
    {
        private string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading image from disk: " + _filename);
        }
        public void Display()
        {
            Console.WriteLine("Displaying image: " + _filename);
        }
    }
}
