using _2Ex6._01._2Ex5._03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex6._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int start = 0;
            int end = 0;

            Random rnd = new Random();
            try
            {
                start = rnd.Next(1, 20);
                end = rnd.Next(1, 10);
                if (start > end)
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
