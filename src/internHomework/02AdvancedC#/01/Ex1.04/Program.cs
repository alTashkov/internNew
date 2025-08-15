class Program
{
    static void Main()
    {
        Console.Write("Enter amount of integers: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter number to find the closest to: ");
        int K = int.Parse(Console.ReadLine());

        int[] ints = new int[N];

        
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter number {i+1}: ");
            int num = int.Parse(Console.ReadLine());

            ints[i] = num;
        }

        Array.Sort(ints);

        int largestNumberSmallerOrEqualToKIndex = -1;

        int largestNumberSmallerOrEqualToK = K;

        while (largestNumberSmallerOrEqualToKIndex < 0)
        {
            largestNumberSmallerOrEqualToKIndex = Array.BinarySearch(ints, largestNumberSmallerOrEqualToK);
            largestNumberSmallerOrEqualToK--;
        }

        Console.WriteLine($"Largest number <= {K}: {ints[largestNumberSmallerOrEqualToKIndex]}");
    }
}