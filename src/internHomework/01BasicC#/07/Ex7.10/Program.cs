class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter target sum: ");

        int targetSum = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool found = false;

        for (int i = 0; i < numbers.Length; i++) 
        {
            int sum = 0;

            for (int j = i; j < numbers.Length; j++)
            {
                sum += numbers[j];
                if(sum == targetSum)
                {
                    Console.WriteLine("\nSequence found!");
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(numbers[k] + " ");
                    }
                    found = true;
                    break;
                }
            }

            if (found)
            {
                break;
            }

        }

        if (!found)
        {
            Console.WriteLine("No Subset Adds To Sum");
        }


    }
}