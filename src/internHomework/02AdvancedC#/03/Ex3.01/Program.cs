class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
		try
		{
			float num = float.Parse(Console.ReadLine());
			if (num > 0)
			{
				Console.WriteLine($"{Math.Sqrt(num):F3}");
			}
			else
			{
				Console.WriteLine("Number must be positive");
			}
		}
		catch (FormatException)
		{
			Console.WriteLine("Invalid number!");
		}
		finally
		{
            Console.WriteLine("Good bye");
        }
    }
}
