class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine($"ASCII 33-126: ");
        for (int i = 33; i <= 126; i++)
        {
            Console.Write($"{(char)i}");
        }
    }
}