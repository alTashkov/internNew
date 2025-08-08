class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number to convert: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine((number.ToString("D").PadLeft(15, ' ')));
        Console.WriteLine(number.ToString("X").PadLeft(15, ' '));
        Console.WriteLine(number.ToString("P").PadLeft(15, ' '));
        Console.WriteLine(number.ToString("E").PadLeft(15, ' '));
    }
}