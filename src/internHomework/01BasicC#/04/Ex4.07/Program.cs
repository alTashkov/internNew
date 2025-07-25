class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number n for [1, n]: ");
        int n = int.Parse(Console.ReadLine()!);
        
        while (n < 1 || n > 1000)
        {
            Console.WriteLine("Number must be in the range [1;1000)");
            Console.Write("Please enter another number: ");
            n = int.Parse(Console.ReadLine()!);
        }

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}