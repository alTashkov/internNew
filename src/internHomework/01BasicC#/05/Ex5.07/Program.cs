class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter num 1: ");
        int n1 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter num 2: ");
        int n2 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter num 3: ");
        int n3 = int.Parse(Console.ReadLine()!);

        int largest = n1;
        int middle = 0;
        int smallest = 0;

        if (largest < n2)
        {
            largest = n2;
            middle = n1;
            smallest = n3;

            if(middle < smallest)
            {
                int temp = smallest;
                smallest = middle;
                middle = temp;
            }
        }

        if (largest < n3)
        {
            largest = n3;
            middle = n1;
            smallest = n2;

            if (middle < smallest)
            {
                int temp = smallest;
                smallest = middle;
                middle = temp;
            }
        }
        
        Console.Write($"Numbers descending: {largest},{middle},{smallest}");

    }
}