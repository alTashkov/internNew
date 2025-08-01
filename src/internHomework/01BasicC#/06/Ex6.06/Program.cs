class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number x: ");
        int k = int.Parse(Console.ReadLine());


        double factorielN = 1.0;
        double factorielK = 1.0;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorielK *= i;
            }
            factorielN *= i;

        }

        Console.WriteLine($"{n}! ({factorielN}) / {k}! ({factorielK}) = {factorielN / factorielK}");

    }
}