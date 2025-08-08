class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter date 1: ");
        string date1 = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Enter date 2: ");
        string date2 = Console.ReadLine();

        if (DateTime.Parse(date1) != DateTime.Parse(date2))
        {
            if (DateTime.Parse(date2) > DateTime.Parse(date1))
            {
                Console.WriteLine("Distance: " + (DateTime.Parse(date2) - DateTime.Parse(date1)).Days + " days");
            }
            else
            {
                Console.WriteLine("Distance: " + (DateTime.Parse(date1) - DateTime.Parse(date2)).Days + " days");
            }
        }

    }
}