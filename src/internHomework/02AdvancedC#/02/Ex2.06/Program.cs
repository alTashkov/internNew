class Program
{
    static void Main(string[] args)
    {
        string[] maxTwentyString = new string[20];

        
        for (int i = 0; i < maxTwentyString.Length; i++)
        {
            Console.Write("Enter a character: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Enter key was pressed. Breaking the loop.");
                maxTwentyString[i] = " ";
                break;
            }

            char c = input[0];

            maxTwentyString[i] = c.ToString();

        }

        for (int i = 0; i < maxTwentyString.Length; i++)
        {
            if (maxTwentyString[i] == null || maxTwentyString[i] == " ")
            {
                maxTwentyString[i] = "*";
            }
            Console.Write(maxTwentyString[i] + " ");
        }

    }
}