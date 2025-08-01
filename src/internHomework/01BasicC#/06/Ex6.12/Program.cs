class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        long numberInDecimal = long.Parse(Console.ReadLine());

        if (numberInDecimal == 0)
        {
            Console.WriteLine("Binary: 0");
            return;
        }

        long remainder = numberInDecimal;

        List<char> numberInBinaryReversed = new List<char>();

        while (remainder > 0)
        {
            numberInBinaryReversed.Add((char)('0' + (remainder % 2)));
            remainder = remainder / 2;
        }

        numberInBinaryReversed.Reverse();

        string numberInBinary = new string(numberInBinaryReversed.ToArray());

        Console.WriteLine("Binary: " + numberInBinary);
    }
}
