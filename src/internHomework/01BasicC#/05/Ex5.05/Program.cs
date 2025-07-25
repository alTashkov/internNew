class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        double biggest = a;

        biggest = biggest > b ? biggest : b > biggest ? b : 0;
        biggest = biggest > c ? biggest : c > biggest ? c : 0;

        Console.WriteLine($"Biggest number of {a},{b},{c} is: {biggest}");

    }
}