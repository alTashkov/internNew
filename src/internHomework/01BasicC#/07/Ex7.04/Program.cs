class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers; ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        int currentMaximalSequence = 1;
        int maximalSequence = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int num = int.Parse(Console.ReadLine());

            numbers[i] = num;
            if (i > 0)
            {
                if (numbers[i] == numbers[i - i])
                {
                    currentMaximalSequence++;
                    if (currentMaximalSequence > maximalSequence)
                    {
                        maximalSequence = currentMaximalSequence;
                    }
                }
                else
                {
                    currentMaximalSequence = 0;
                }
            }
        }

        Console.WriteLine("Maximal sequence of numbers: " +  maximalSequence);

    }
}