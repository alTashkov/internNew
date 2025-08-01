class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter amount of numbers to find sum of: ");
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i+1}: ");
            int num = int.Parse(Console.ReadLine());

            numbers[i] = num;
        }

        Array.Sort(numbers);
        Array.Reverse(numbers);

        int sum = 0;

        for (int i = 0; i < k; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine($"Maximal sum of {k} elements: {sum}");
    }
}