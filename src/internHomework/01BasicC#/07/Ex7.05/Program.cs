class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        int currentMaximalIncreasingSq = 1;
        int maximalIncreasingSq = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i+1}: ");
            int num = int.Parse(Console.ReadLine());

            numbers[i] = num;

            if (i > 0)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentMaximalIncreasingSq++;
                }
                else
                {
                    currentMaximalIncreasingSq = 0;
                }
            }

            if (maximalIncreasingSq < currentMaximalIncreasingSq)
            {
                maximalIncreasingSq = currentMaximalIncreasingSq;
            }
        }

        Console.WriteLine($"Maximal increasing sequence: {maximalIncreasingSq + 1}");
    }
}