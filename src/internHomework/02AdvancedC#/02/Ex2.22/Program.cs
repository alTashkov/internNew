using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.WriteLine();

        string[] words = text.Split(new[] { ' ', ',', '.', '!', '\"' }, StringSplitOptions.RemoveEmptyEntries);

        string[] uniqueWords = new string[words.Length];
        int uniqueIdx = 0;

        for (int i = 0; i < words.Length; i++)
        {
            int wordCount = 0;
            string currentWord = words[i];
            bool isUnique = true;

            for (int z = 0; z < uniqueWords.Length; z++)
            {
                if ((currentWord.ToLower()).Equals(uniqueWords[z]?.ToLower()))
                {
                    isUnique = false;
                }
            }

            if (isUnique)
            {
                uniqueWords[uniqueIdx++] = currentWord;
                for (int j = i; j < words.Length; j++)
                {
                    if ((currentWord.ToLower()).Equals(words[j].ToLower()))
                    {
                        wordCount++;
                    }
                }
                Console.WriteLine(currentWord + " is found " + wordCount + " times.");
                
                
            }
            else
            {
                continue;
            }
        }

    }
}