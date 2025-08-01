class Program
{
    static void MergeArrays(int[] array, int start, int middle, int end)
    {
        int leftSize = middle - start + 1;
        int rightSize = end - middle;

        int[] leftPart = new int[leftSize];
        int[] rightPart = new int[rightSize];

        int i = 0; int j = 0;

        for (; i < leftSize; i++)
        {
            leftPart[i] = array[start + i];
        }

        for (; j < rightSize; j++)
        {
            rightPart[j] = array[middle + 1 + j];
        }

        i = 0; j = 0;int k = start;

        while(i < leftSize && j < rightSize)
        {
            if (leftPart[i] <= rightPart[j])
            {
                array[k++] = leftPart[i++];
            }
            else
            {
                array[k++] = rightPart[j++];
            }
        }

        while (i < leftSize)
        {
            array[k++] = leftPart[i++];
        }
        while(j < rightSize)
        {
            array[k++] = rightPart[j++];
        }
            
    }

    static void MergeSort(int[] array, int start, int end)
    {
        if(start < end)
        {
            int middle = (start + end) / 2;
            MergeSort(array, start, middle);
            MergeSort(array, middle + 1, end);
            MergeArrays(array, start, middle, end);
        }
    }
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
            Console.Write(numbers[i] + " ");
        }

        MergeSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}