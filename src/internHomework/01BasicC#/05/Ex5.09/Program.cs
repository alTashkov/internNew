class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter data type integer/real/text: ");
        string input = Console.ReadLine()!;
        switch (input)
        {
            case "integer":
                Console.Write("Enter value for your integer: ");
                int num = int.Parse(Console.ReadLine());
                num++;
                Console.WriteLine($"Value of your int + 1: {num}.");
                break;
            case "real":
                Console.Write("Enter value for your double: ");
                double dbl = double.Parse(Console.ReadLine());
                dbl++;
                Console.WriteLine($"Value of your double + 1: {dbl:F2}.");
                break;
            case "text":
                Console.Write("Enter value for the text: ");
                string txt = Console.ReadLine();
                Console.WriteLine($"Value of your text: {txt}*.");
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}