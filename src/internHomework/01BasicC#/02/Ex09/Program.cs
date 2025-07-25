class Program
{

    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine($"Before exchanging -> a = {a}, b = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"After exchanging -> a = {a}, b = {b}");
    }
}