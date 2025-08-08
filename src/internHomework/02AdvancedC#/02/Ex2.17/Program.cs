class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter date 1: ");
        string date1 = Console.ReadLine();

        DateTime firstDate = Convert.ToDateTime(date1);

        DateTime endDate = firstDate.AddHours(6.5);

        Console.WriteLine(firstDate + " after 6.5 hours: " + endDate + $"\nAnd the day of the week: {endDate.DayOfWeek}");
    }
}