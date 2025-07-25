class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        double[] d = { a, b, c };
        
        string sign = "";

        int minusCount = 0;
        
        for (int i = 0; i < d.Length; i++)
        {
            if (d[i] < 0)
            {
                minusCount++;
            }
            else if (d[i] == 0)
            {
                sign = "0";
                break;
            }
        }

        if (minusCount % 2 == 0 && sign != "0")
        {
            sign = "+";
        }
        else if(minusCount % 2 != 0 && sign != "0")
        {
            sign = "-";
        }

        Console.WriteLine($"Multiplication sign of {a},{b},{c}: {sign}.");
        
    }
}