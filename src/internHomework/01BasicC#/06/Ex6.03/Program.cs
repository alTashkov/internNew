class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int num = 0;
        double sum = 0;
        int max = 0;
        int min = 0;
        double avg = 0;
        int prev = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number {i}: ");
            num = int.Parse(Console.ReadLine());

            if (num > prev)
            {
                max = num;
            }
            else if (num < prev)
            {
                min = num;
            }

            sum += num;
            prev = num;
        }

        avg = sum / n;

        Console.WriteLine($"min = {min:F2}\nmax = {max:F2}\nsum = {sum:F2}\navg = {avg:F2}.");
    }
}