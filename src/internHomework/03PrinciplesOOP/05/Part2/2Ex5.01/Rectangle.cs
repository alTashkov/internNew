namespace _2Ex5._01
{
    class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width; 
            Height = height;
        }
        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
