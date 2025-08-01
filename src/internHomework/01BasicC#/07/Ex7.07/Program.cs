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

        int currentMin = 0;
        int numberToSwap = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int minIdx = i;
            currentMin = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (currentMin > numbers[j])
                {
                    currentMin = numbers[j];
                    minIdx = j;
                }
            }

            numberToSwap = numbers[i];
            numbers[i] = currentMin;
            numbers[minIdx] = numberToSwap;

        }

        for (int z = 0; z < numbers.Length; z++)
        {
            Console.Write(numbers[z] + " ");
        }

    }
}