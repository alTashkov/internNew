class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine()!);
        while (a < -100 || a > 100)
        {
            Console.Write("Range is [-100;100]!");
            Console.Write("Enter the number again: ");
            a = double.Parse(Console.ReadLine()!);
        }

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine()!);
        while (b < -100 || b > 100)
        {
            Console.Write("Range is [-100;100]!");
            Console.Write("Enter the number again: ");
            b = double.Parse(Console.ReadLine()!);
        }

        if (a > b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine($"{a} {b}");
    }
}