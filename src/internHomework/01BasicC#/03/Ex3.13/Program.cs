class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        uint num = uint.Parse(Console.ReadLine());

        Console.Write("Enter a position: ");
        int pos = int.Parse(Console.ReadLine());
        while(pos < 0 || pos >= 64)
        {
            Console.WriteLine("Position must be in [0;64)!");
            Console.Write("Please re-enter position: ");
            pos = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter a value (0/1): ");
        int value = int.Parse(Console.ReadLine());
        while (value != 0 && value != 1)
        {
            Console.WriteLine("Value must be 0 or 1.");
            Console.Write("Please re-enter value: ");
            value = int.Parse(Console.ReadLine());
        }

        uint mask = 1u << pos;

        num = num & ~mask;

        if (value == 1)
        {
            num = num | mask;
        }

        Console.WriteLine($"Resulting number: {num}");

    }
}
