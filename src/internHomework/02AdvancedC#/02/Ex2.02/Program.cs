class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string stringToReverse = Console.ReadLine();

        char[] chars = stringToReverse.ToCharArray();

        Array.Reverse(chars);

        string reversedString = new string(chars);

        Console.WriteLine(reversedString);
        
    }
}