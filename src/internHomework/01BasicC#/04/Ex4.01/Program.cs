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

        Console.WriteLine($"The sum of {a},{b},{c} is {a + b + c}.");

    }
}