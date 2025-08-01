class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxSoFar = numbers[0];
        int currentMax = numbers[0];

        for (int i = 1; i < n; i++)
        {
            currentMax = Math.Max(numbers[i], currentMax + numbers[i]);
            maxSoFar = Math.Max(maxSoFar, currentMax);
        }

        Console.WriteLine("Maximal sum of consecutive elements: " + maxSoFar);
    }
}
