using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter word to look for: ");
        string word = Console.ReadLine();

        int wordCount = 0;
        int index = 0;

        while ((index = text.IndexOf(word, index)) != -1)
        {
            wordCount++;
            index += word.Length;
        }

        Console.WriteLine($"Result: {wordCount}");
    }
}