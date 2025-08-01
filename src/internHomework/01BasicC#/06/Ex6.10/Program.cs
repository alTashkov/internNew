class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"Enter {n} numbers, separated by whitespace: ");
        string numbers = Console.ReadLine();

        int evenProduct = 1;
        int oddProduct = 1;

        char[] numbersChars = numbers.ToCharArray();
        for (int i = 0; i < numbersChars.Length; i++)
        {
            int a;
            bool res = int.TryParse(numbersChars[i].ToString(), out a);
            if (res)
            {
                if (a % 2 == 0)
                {
                    evenProduct *= a;
                }
                else
                {
                    oddProduct *= a;
                }
            }
        }

        Console.WriteLine(oddProduct == evenProduct ?
                                $"yes {evenProduct}" :
                                $"no {oddProduct} {evenProduct}");
    }
}
