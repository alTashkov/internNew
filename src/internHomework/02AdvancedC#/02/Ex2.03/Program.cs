class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write expression: ");
        string expression = Console.ReadLine();

        int openingCount = 0;
        int closingCount = 0;
        bool isIncorrectOrder = false;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                openingCount++;
            }
            else if (expression[i] == ')')
            {
                closingCount++;
            }
            if (closingCount > openingCount)
            {
                isIncorrectOrder = true;
                break;
            }
        }

        if (openingCount != closingCount || isIncorrectOrder)
        {
            Console.WriteLine("Incorrect expresion!");
        }
        else
        {
            Console.WriteLine("Correct expression.");
        }
    }
}