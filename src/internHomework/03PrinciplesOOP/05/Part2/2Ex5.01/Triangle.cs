namespace _2Ex5._01
{
    class Triangle : Shape
    {
        public Triangle(int width, int height)
        {
            Height = height;
            Width = width;
        }
        public override double CalculateSurface()
        {
            return (Height * Width) / 2;
        }
    }
}
