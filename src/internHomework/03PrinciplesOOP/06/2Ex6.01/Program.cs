using System;
namespace _2Ex6._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start;
            int end;

            Random rnd = new Random();
            try
            {
                start = rnd.Next(-30, 10);
                end = rnd.Next(50, 150);
                if (start < 1 || end > 100)
                {
                    throw new InvalidRangeException<int>(start, end);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                DateTime date2 = new DateTime(2012, 3, 23, 3, 23, 25);
                DateTime date1 = new DateTime(1999, 2, 12, 15, 0, 25);

                if (DateTime.Compare(date2, date1) > 0)
                {
                    throw new InvalidRangeException<DateTime>(date2, date1);
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }

            Person personWithNameOnly = new Person("Ivan Ivanov");
            Console.WriteLine(personWithNameOnly);

            Person personWithAgeAndName = new Person("Ivan Petrov", 35);
            Console.WriteLine(personWithAgeAndName);

        }
    }
}
