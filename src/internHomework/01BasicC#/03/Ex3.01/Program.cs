class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        
        int number = int.Parse(Console.ReadLine());

        if(number >= -30 && number <= 30)
        {
            bool isEven = (number % 2 == 0);
            Console.WriteLine(isEven ? $"even {number}" : $"odd {number}");
        }
        else
        {
            Console.WriteLine("The number you entered is invalid (range is [-30,30])");
        }
    }
}
