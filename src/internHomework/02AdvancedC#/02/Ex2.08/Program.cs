class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter word to look for: ");
        string desiredWord = Console.ReadLine();

        string[] sentences = text.Split('.');

        for (int i = 0; i < sentences.Length; i++)
        {
            string[] wordsInSentence = sentences[i].Split(' ');

            for (int j = 0; j < wordsInSentence.Length; j++)
            {
                if (wordsInSentence[j] == desiredWord)
                {
                    Console.Write(sentences[i] + ". ");
                    break;
                }
            }
        }
    }
}