class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());
        while(n < 1 || n > 200)
        {
            Console.Write($"The amount of numbers must be in the range [1;200]!");
            Console.Write("Enter amount of numbers: ");
            n = int.Parse(Console.ReadLine()!);
        }

        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number {i}: ");
            double currentNum = double.Parse(Console.ReadLine()!);
            while (currentNum > 1000 || currentNum < -1000)
            {
                Console.Write($"The number must be in the range [-1000;1000]!");
                Console.Write($"Enter number {i}: ");
                currentNum = double.Parse(Console.ReadLine()!);
            }

            sum += currentNum;
        }

        Console.WriteLine($"Sum of the {n} numbers: {sum}");
    }
}