class Program
{

    static void Main(string[] args)
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine($"nullInt: {nullInt}");
        Console.WriteLine($"nullDouble: {nullDouble}");

        int? sumA = nullInt + 5;
        double? sumB = nullDouble + 3.5;
        Console.WriteLine($"nullInt + 5: {sumA}");
        Console.WriteLine($"nullDouble + 3.5: {sumB}");
        //AT - it's null, always
    }
}
