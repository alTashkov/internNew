class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        uint num = uint.Parse(Console.ReadLine());
        
        Console.WriteLine((num >> 3) & 1);
    }
}
