namespace _2Ex5._01
{
    class Square : Shape
    {
        private int width;
        private int height;
        
        public override int Width
        {
            get { return width; }
            set { width = value; }
        }

        public override int Height
        {
            get { return height; }
            set { height = width; }
        }

        public Square(int width)
        {
            this.width = width;
            height = width;
        }
        public override int CalculateSurface()
        {
            return Height * Width;
        }
    }
}
