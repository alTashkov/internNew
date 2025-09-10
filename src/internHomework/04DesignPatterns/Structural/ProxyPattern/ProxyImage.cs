namespace ProxyPattern
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string _filename;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(_filename);
            }

            realImage.Display();
        }
    }
}
