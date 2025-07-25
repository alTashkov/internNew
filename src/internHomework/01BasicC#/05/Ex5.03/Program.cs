class Program
{
    static void Main(string[] args)
    {
        string[] validCards = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
        Console.Write("Enter a card sign: ");
        string s = Console.ReadLine()!;
        while (s?.Length < 1 || s?.Length > 5)
        {
            Console.WriteLine("The card sign must be [1;5]!");
            Console.Write("Enter a new card sign: ");
            s = Console.ReadLine()!;
        }

        int count = 0;
        for (int i = 0; i < validCards.Length; i++)
        {
            if (validCards[i] == s)
            {
                Console.WriteLine($"yes {s}");
                count++;
                break;
            }
            else
            {
                continue;
            }
        }

        if (count == 0)
        {
            Console.WriteLine($"no {s}");
        }
    }
}