class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number 1: ");
        int a = int.Parse(Console.ReadLine());
        while (a > 1000 || a < -1000)
        {
            Console.WriteLine("Numbers must be in the range [-1000;1000]!");
            Console.Write("Please enter a new number: ");
            a = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number 2: ");
        int b = int.Parse(Console.ReadLine());
        while (b > 1000 || b < -1000)
        {
            Console.WriteLine("Numbers must be in the range [-1000;1000]!");
            Console.Write("Please enter a new number: ");
            b = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number 3: ");
        int c = int.Parse(Console.ReadLine());
        while (c > 1000 || c < -1000)
        {
            Console.WriteLine("Numbers must be in the range [-1000;1000]!");
            Console.Write("Please enter a new number: ");
            c = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number 4: ");
        int d = int.Parse(Console.ReadLine());
        while (d > 1000 || d < -1000)
        {
            Console.WriteLine("Numbers must be in the range [-1000;1000]!");
            Console.Write("Please enter a new number: ");
            d = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number 5: ");
        int e = int.Parse(Console.ReadLine());
        while (e > 1000 || e < -1000)
        {
            Console.WriteLine("Numbers must be in the range [-1000;1000]!");
            Console.Write("Please enter a new number: ");
            e = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Sum of numbers: {a + b + c + d + e}");
    }
}