class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number: ");
        string numberInBinary = Console.ReadLine();

        char[] binaryNumbersSeparated = numberInBinary.ToCharArray();

        long numberInDecimal = 0;

        for (int i = 0; i < binaryNumbersSeparated.Length; i++)
        {
            if (binaryNumbersSeparated[i] == '1')
            {
                int power = binaryNumbersSeparated.Length - 1 - i;
                numberInDecimal += (long)Math.Pow(2, power);
            }
        }

        Console.WriteLine(numberInDecimal);
    }
}