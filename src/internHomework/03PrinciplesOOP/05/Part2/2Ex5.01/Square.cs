namespace _2Ex5._01
{
    class Square : Shape
    {
        public Square(int width)
        {
            Width = width;
            Height = width;
        }
        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
