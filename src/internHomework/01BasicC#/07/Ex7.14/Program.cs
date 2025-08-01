class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i+1}: ");
            int num = int.Parse(Console.ReadLine());

            numbers[i] = num;
        }

        Console.WriteLine("Unsorted array: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        QuickSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

    }

    static void QuickSort(int[] array, int start, int end)
    {
        if(end <= start)
        {
            return;
        }

        int pivot = Partition(array, start, end);
        QuickSort(array, start, pivot - 1);
        QuickSort(array, pivot + 1, end);
    }

    static int Partition(int[] array, int start, int end)
    {
        int pivot = array[end];
        int i = start - 1;
        int temp;

        for (int j = start; j < end; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        i++;

        temp = array[i];
        array[i] = array[end];
        array[end] = temp;

        return i;
    }
}