class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the rectangle: ");
        double height = double.Parse(Console.ReadLine());
        
        double perimeter = 2 * (width + height);

        double area = width * height;
        
        Console.WriteLine($"Perimeter: {perimeter:F2}" +
            $"\nArea: {area:F2}");

    }
}
