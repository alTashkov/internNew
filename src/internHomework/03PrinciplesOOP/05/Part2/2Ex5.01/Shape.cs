namespace _2Ex5._01
{
    public abstract class Shape
    {
        public double Width { get; protected set; }

        public double Height { get; protected set; }

        public abstract double CalculateSurface();
    }
}
