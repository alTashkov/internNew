class Program
{
    static void Main(string[] args)
    {
        string text = "I have a friend named Hannah who loves to tell errrre. ABBA She once told me a tale about a racecar driver who was so fast, he'd often say, \"I can't wait to get back in that racecar!\" She's a bit of a jokester and sometimes her stories are a bit silly.";

        string[] subStrings = text.Split(' ');

        for (int i = 0; i < subStrings.Length; i++)
        {
            string word = subStrings[i].ToLower();

            string reversedWord = new string(word.Reverse().ToArray());

            if (word.Length > 1)
            {
                if (word.Equals(reversedWord))
                {
                    Console.WriteLine($"Palindrome found: {subStrings[i]}");
                }
            }

            
            
        }
    }
}