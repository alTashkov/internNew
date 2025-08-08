class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        string[] stringToConvert = new string[input.Length];

        for (int i = 0; i < stringToConvert.Length; i++)
        {
            if (input[i] != ' ')
            {
                stringToConvert[i] = "\\u" + ((int)input[i]).ToString("X4"); ;
            }

            Console.Write(stringToConvert[i]);
        }

        
    }
}