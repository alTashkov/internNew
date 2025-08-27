namespace Ex4._01
{
    public class Display
    {
        private double? size;

        private long? numberOfColors;

        public double? Size
        {
            get { return size; }
            set { size = value; }
        }

        public long? NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }

        public Display(double? size, long? numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
    }
}
