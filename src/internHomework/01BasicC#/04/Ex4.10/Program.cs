class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int n = int.Parse(Console.ReadLine());
        while (n < 0)
        {
            Console.Write("Please enter a valid number >= 0!: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter second number: ");
        int m = int.Parse(Console.ReadLine());
        while (m < n || m > 2000)
        {
            Console.Write($"Please enter a valid number [{n};2000]!: ");
            n = int.Parse(Console.ReadLine());
        }


        int count = 0;
        for(int i = n + 1; i < m; i++)
        {
            if(i % 5 == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Numbers divisable by 5 between {n} and {m}: {count}");
    }
}