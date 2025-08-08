class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number {i} of first array: ");
            int numA = int.Parse(Console.ReadLine());
            arr1[i - 1] = numA;
        }

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"Enter number {j} of first array: ");
            int numB = int.Parse(Console.ReadLine());
            arr2[j - 1] = numB;
        }

        bool areSameArrays = true;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                areSameArrays = false;
                break;
            }
        }

        Console.WriteLine(areSameArrays ? "Equal" : "Not equal");
    }

}
