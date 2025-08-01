class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter card sign: ");
        char sign = char.Parse(Console.ReadLine());

        string[] validCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int num = 0;
        for (int i = 0; i < validCards.Length; i++)
        {
            if (validCards[i].Equals(sign.ToString()))
            {
                num = i;
            }
        }

        for (int i = 0; i <= num; i++)
        {
            Console.WriteLine($"{validCards[i]} of spades, {validCards[i]} of clubs, {validCards[i]} of hearts, {validCards[i]} of diamonds\r\n");
        }

    }
}