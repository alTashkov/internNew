class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        char[] letters = word.ToCharArray();
        char[] uniques = new char[letters.Length];
        int uniqueIdx = 0;

        for (int i = 0; i < letters.Length; i++)
        {
            int letterCount = 0;
            char currentLetter = letters[i];
            bool isUnique = true;

            for (int z = 0; z < uniques.Length; z++)
            {
                if (currentLetter == uniques[z])
                {
                    isUnique = false;  
                }
            }

            if (isUnique)
            {
                uniques[uniqueIdx++] = currentLetter;
                for (int j = i; j < letters.Length; j++)
                {
                    if (currentLetter == letters[j])
                    {
                        letterCount++;
                    }
                }
                Console.WriteLine(currentLetter + " is found " + letterCount + " times.");
            }
            else
            {
                continue;
            }
            
        }
    }
}