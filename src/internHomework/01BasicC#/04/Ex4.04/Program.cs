class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter another number: ");
        double b = double.Parse(Console.ReadLine());


        Console.WriteLine((a > b) ? $"{a} is greater." : $"{b} is greater.");
    }
}