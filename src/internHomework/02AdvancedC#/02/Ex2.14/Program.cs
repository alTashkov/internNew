class Program
{
    static void Main(string[] args)
    {
        string[] dictionary = {".NET","platform for applications from Microsoft","CLR",
            "managed execution environment for .NET","namespace","hierarchical organization of classes" };

        Console.Write("Enter word to find definition of: ");
        string word = Console.ReadLine();
        Console.WriteLine();
        for (int i = 0; i < dictionary.Length; i+=2) 
        {
            if (word == dictionary[i])
            {
                Console.WriteLine(word+": " +  dictionary[i+1]);
                break;
            }      
        }
    }
}