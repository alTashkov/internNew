class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        //while (n < 2 || n > 10)
        //{
        //    Console.WriteLine("N must be in the range (2;10]!\nPlease re-enter N: ");
        //    n = int.Parse(Console.ReadLine());
        //}removed because of feedback

        Console.Write("Enter number x: ");
        double x = double.Parse(Console.ReadLine());
        //while (x < 0.5 || x > 100)
        //{
        //    Console.WriteLine("X must be in the range (0.5;100]!\nPlease re-enter N: ");
        //    x = int.Parse(Console.ReadLine());
        //}removed because of feedback

        double sum = 1;
        double factorielN = 1;
        double powerOfX = 1;
        for (int i = 1; i <= n; i++) 
        {
            factorielN *= i;
            powerOfX *= x;
            sum += factorielN / powerOfX;

        }

        Console.WriteLine($"S: {sum:F5}");
    }
}