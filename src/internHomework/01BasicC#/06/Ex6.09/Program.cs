class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write($"{j+i} ");
            }
            Console.WriteLine();
        }
    }
}