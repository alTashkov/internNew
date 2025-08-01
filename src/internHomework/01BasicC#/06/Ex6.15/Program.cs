class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number a and b: ");
        string rawInput = Console.ReadLine();

        char[] whitespace = new char[] { ' ', '\t' };

        string[] numbers = rawInput.Split(whitespace);

        int a = int.Parse(numbers[0].ToString());
        Console.WriteLine("Number a found!: " + a);

        int b = int.Parse(numbers[1].ToString());
        Console.WriteLine("Number b found!: " + b);

        int GCD = 0;

        int previousValueOfSecondNumber = 0;

        while (b != 0)
        {
            previousValueOfSecondNumber = b;
            b = a % b;
            a = previousValueOfSecondNumber;
        }

        GCD = a;
        Console.WriteLine($"Greatest common divisor: {GCD}");



    }
}