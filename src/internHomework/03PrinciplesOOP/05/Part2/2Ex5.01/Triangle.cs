namespace _2Ex5._01
{
    class Triangle : Shape
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

        public Triangle(int width, int height)
        {
            this.height = height;
            this.width = width;
        }
        public override int CalculateSurface()
        {
            return (height * width) / 2;
        }
    }
}
