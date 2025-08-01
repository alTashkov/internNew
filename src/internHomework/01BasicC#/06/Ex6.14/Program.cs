class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string numberInHex = Console.ReadLine();

        string hexDigits = "0123456789ABCDEF";

        int power = numberInHex.Length - 1;

        long numberInDecimal = 0;

        for (int i = 0; i < numberInHex.Length; i++)
        {
            for (int j = 0; j < hexDigits.Length; j++)
            {
                if(numberInHex[i] == hexDigits[j])
                {
                    int extractedNumberfromInput = j;
                    numberInDecimal += (long)(extractedNumberfromInput * Math.Pow(16,power - i));
                }
            }
        }

        string numberInDecimalString = numberInDecimal.ToString();
        Console.WriteLine("Hex to decimal: " + numberInDecimalString);

    }
}