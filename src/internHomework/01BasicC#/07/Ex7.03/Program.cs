class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text 1: ");
        string firstStr = Console.ReadLine();

        Console.Write("Enter text 2: ");
        string secondStr = Console.ReadLine();

        firstStr.Replace(" ", "");
        secondStr.Replace(" ", "");

        char[] charNoSpaceOne = firstStr.ToCharArray();
        char[] charNoSpaceTwo = secondStr.ToCharArray();

        if (charNoSpaceTwo.Length == charNoSpaceOne.Length)
        {
            Console.WriteLine("=");
        }
        else if (charNoSpaceOne.Length < charNoSpaceTwo.Length)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine(">");
        }
    }
    }