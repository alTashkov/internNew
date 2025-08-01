class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int num = int.Parse(Console.ReadLine());

            numbers[i] = num;
        }

        int maxAmountOfNumbers = 1;
        int numberWithMostOccurrences = 0;

        for (int i = 0; i < n - 1; i++)
        {

            int currentNumberFoundAmount = 1;

            for (int j = i+1; j < n; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    currentNumberFoundAmount++;

                }
            }
            if (currentNumberFoundAmount > maxAmountOfNumbers)
            {
                maxAmountOfNumbers = currentNumberFoundAmount;
                numberWithMostOccurrences = numbers[i];
            }
        }

        Console.WriteLine($"{numberWithMostOccurrences} ({maxAmountOfNumbers} times)");
    }
}