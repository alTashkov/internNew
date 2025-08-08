class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter forbidden words, separated by space: ");
        string input = Console.ReadLine();

        string[] forbiddenWords = input.Split(" ");

        Console.WriteLine("Enter text to edit: ");
        string text = Console.ReadLine();

        string[] wordsInSentence = text.Split(" ");

        Console.WriteLine();
        Console.WriteLine("Edited text");
        Console.WriteLine("-----------");
        Console.WriteLine();

        for (int i = 0; i < wordsInSentence.Length; i++)
        {
            
            for (int j = 0; j < forbiddenWords.Length; j++)
            {
                if (wordsInSentence[i].Contains(forbiddenWords[j]))
                {
                    string amountOfAsterisks = new string('*', forbiddenWords[j].Length);
                    wordsInSentence[i] = wordsInSentence[i].Replace(forbiddenWords[j], amountOfAsterisks);
                    break;
                }
            }
            Console.Write(wordsInSentence[i] + " ");
        }

        Console.WriteLine();
        
    }
}
