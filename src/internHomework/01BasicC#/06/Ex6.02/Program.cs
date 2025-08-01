class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        while (n < 1 || n > 1500)
        {
            Console.WriteLine("N must be in the range (1,1500)");
            Console.Write("Please re-enter n: ");
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            else
            {
                Console.Write(i + " ");
            }
                
        }
    }
}