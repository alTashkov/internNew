class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());

        double D = b * b - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else if(D == 0)
        {
            double x = (-b)/(2*a);
            Console.WriteLine($"One root: {x:F2}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine(x1 < x2
                ? $"Two roots: {x1:F2} and {x2:F2}"
                : $"Two roots: {x2:F2} and {x1:F2}");
        }
    }
}