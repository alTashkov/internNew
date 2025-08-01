class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        long numberInDecimal = long.Parse(Console.ReadLine());

        if (numberInDecimal == 0)
        {
            Console.WriteLine("Hex: 0");
            return;
        }

        string hexDigits = "0123456789ABCDEF";
        
        long remainder = numberInDecimal;

        List<char> hexNumberReversed = new List<char>();

        while (remainder > 0)
        {
            hexNumberReversed.Add(hexDigits[(int)(remainder % 16)]);
            remainder = remainder / 16;
        }

        hexNumberReversed.Reverse();

        string hexNumber = new string(hexNumberReversed.ToArray());

        Console.WriteLine("Hex: " + hexNumber);
    }
}