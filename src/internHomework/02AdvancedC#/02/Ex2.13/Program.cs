class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter sentence: ");
        string input = Console.ReadLine();
        string[] sentenceAndEndSign = new string[2];

        char[] signs = {'!','.','?'};

        char sign = ' ';

        for (int i = 0; i < signs.Length; i++)
        {
            if (input[input.Length-1] == signs[i])
            {
                sentenceAndEndSign = input.Split(signs[i]);
                sign = signs[i];
                break;
            }
        }

        string[] sentenceWords = sentenceAndEndSign[0].Split(' ');

        for (int i = 0; i < sentenceWords.Length/2; i++)
        {
            string temp = sentenceWords[i];
            sentenceWords[i] = sentenceWords[i].Replace(sentenceWords[i], sentenceWords[sentenceWords.Length - 1 - i]);
            sentenceWords[sentenceWords.Length - 1 - i] = sentenceWords[i].Replace(sentenceWords[sentenceWords.Length - 1 - i],temp);
        }

        for (int i = 0; i < sentenceWords.Length; i++)
        {
            Console.Write(sentenceWords[i] + " ");
        }

        Console.Write(sign);

    }
}