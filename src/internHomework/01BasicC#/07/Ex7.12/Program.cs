class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine(j);
                }
            }

        }
    }
}