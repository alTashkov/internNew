class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a radius: ");
        double radius = double.Parse(Console.ReadLine());

        while(radius < 0)
        {
            Console.Write("Radius must be a positive number!: ");
            radius = double.Parse(Console.ReadLine());
        }

        double perimeter = radius * 2 * Math.PI;
        perimeter = Math.Round(perimeter, 2);
        
        double area = Math.PI * radius * radius;
        area = Math.Round(area, 2);

        Console.WriteLine($"Perimeter of circle: {perimeter:F2}\nArea of circle: {area:F2}");

    }
}