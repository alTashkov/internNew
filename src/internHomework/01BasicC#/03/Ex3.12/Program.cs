class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        uint num = uint.Parse(Console.ReadLine());
        while (num > 255)
        {
            Console.WriteLine("Number must be in [0;255]!");
            Console.Write("Please re-enter number: ");
            num = uint.Parse(Console.ReadLine());
        }

        Console.Write("Enter position to check: ");
        uint pos = uint.Parse(Console.ReadLine());
        while (pos >= 55)
        {
            Console.WriteLine("Position must be in (0;55)!");
            Console.Write("Please re-enter position: ");
            pos = uint.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The {pos} bit of {num} is: {(num >> (int)pos) & 1}");
    }
}
