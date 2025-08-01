class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Catalan numbers");
        Console.WriteLine("--------------");

        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());

        double factorielN = 1.0;
        double factoriel2N = 1.0;
        double factorielNplusOne = 1.0;

        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
        }

        for (int j = 1; j <= (2*n); j++)
        {
            factoriel2N *= j;
        }

        for (int z = 1; z <= (n+1); z++)
        {
            factorielNplusOne *= z;
        }

        Console.WriteLine($"{n} catalan number: {Math.Round(factoriel2N / (factorielNplusOne * factorielN))}");


    }
}