class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of fibunacci numbers: ");
        int n = int.Parse(Console.ReadLine()!);
        while (n < 1 || n > 50)
        {
            Console.WriteLine("Amount must be in the range [1;50]!");
            Console.Write("Please enter new amount: ");
            n = int.Parse(Console.ReadLine()!);
        }

        int first = 0;
        int second = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + ", ");
            
            int next = first + second;
            
            first = second;
            second = next;
        }
    }
}