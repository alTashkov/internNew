class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter list of words: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
            
        Array.Sort(words);

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}