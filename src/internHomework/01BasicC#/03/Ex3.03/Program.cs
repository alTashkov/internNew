class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isDivisable = (number % 7 == 0 && number % 5 == 0);

        Console.WriteLine($"{isDivisable} {number}");

    }
}
