using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a number (p): ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter a number (q): ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Enter a number (k): ");
        int k = int.Parse(Console.ReadLine());

        int mask = (1 << k) - 1;

        int firstBits = (n >> p) & mask;
        int secondBits = (n >> q) & mask;

        n = n & ~(mask << p);
        n = n & ~(mask << q);

        n = n | (firstBits << q);
        n = n | (secondBits << p);

        Console.WriteLine($"Number after swaps: {n}");

    }
}
