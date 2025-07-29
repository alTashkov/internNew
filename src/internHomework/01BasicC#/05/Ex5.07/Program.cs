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

        int largest = 0;
        int middle = 0;
        int smallest = 0;

        if (n1 > n2)
        {
            largest = n1;
            if (n3 > n1)
            {
                largest = n3;
                middle = n1;
                smallest = n2;
            }
            if (n2 <= n3 && largest == n1)
            {
                middle = n3;
                smallest = n2;
            }
            if (n2 >= n3 && largest == n1)
            {
                middle = n2;
                smallest = n3;
            }
            
        }
        else if (n1 < n2)
        {
            largest = n2;
            if (n3 > n2)
            {
                largest = n3;
                middle = n2;
                smallest = n1;
            }
            if (n1 <= n3 && largest == n2)
            {
                middle = n3;
                smallest = n1;
            }
            if (n1 >= n3 && largest == n2)
            {
                middle = n1;
                smallest = n3;
            }
        }


            Console.Write($"Numbers descending: {largest},{middle},{smallest}");

    }
}