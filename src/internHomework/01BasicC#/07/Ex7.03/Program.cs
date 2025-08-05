class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text 1: ");
        string firstStr = Console.ReadLine();

        Console.Write("Enter text 2: ");
        string secondStr = Console.ReadLine();

        char[] charNoSpaceOne = firstStr.Replace(" ", "").ToCharArray();
        char[] charNoSpaceTwo = secondStr.Replace(" ", "").ToCharArray();

        int countOne = 0;
        int countTwo = 0;

        for (int i = 0; i < charNoSpaceOne.Length; i++)
        {
            if (charNoSpaceOne[i] == charNoSpaceTwo[i])
            {
                if (charNoSpaceOne.Length - 1 == i)
                {
                    Console.WriteLine("The texts are identical.");
                }
                continue;
            }
            else if (charNoSpaceOne[i] > charNoSpaceTwo[i])
            {
                Console.WriteLine("First text is lexicographically greater.");
                break;
            }
            else if (charNoSpaceOne[i] < charNoSpaceTwo[i])
            {
                Console.WriteLine("Second text is lexicographically greater.");
                break;
            }
            
        }

    }
}