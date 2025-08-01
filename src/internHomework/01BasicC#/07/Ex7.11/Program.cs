class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0;i < n; i++)
        {
            Console.Write($"Enter number {i+1}: ");
            int num = int.Parse(Console.ReadLine());

            numbers[i] = num;
        }

        Console.Write("Enter number to find index of: ");
        int x = int.Parse(Console.ReadLine());

        //Array.Sort(numbers);

        int low = 0;
        int high = numbers.Length - 1;
        bool found = false;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (numbers[mid] == x)
            {
                Console.WriteLine(mid);
                found = true;
            }

            if (numbers[mid] < x)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        if (!found)
        {
            Console.WriteLine(-1);
        }
        
    }
}