namespace _2Ex5._01
{
    class Rectangle : Shape
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
            set { height = value; }
        }

        public Rectangle(int width, int height)
        {
            this.width = width; 
            this.height = height;
        }
        public override int CalculateSurface()
        {
            return width * height;
        }
    }
}
