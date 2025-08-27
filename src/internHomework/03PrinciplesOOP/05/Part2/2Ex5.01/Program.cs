using System;

namespace _2Ex5._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Square(5),
                new Rectangle(10,12),
                new Triangle(5,3),
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} area: {shape.CalculateSurface()} cm^2");
            }
        }
    }
}
