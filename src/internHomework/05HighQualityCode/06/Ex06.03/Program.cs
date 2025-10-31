using System;

namespace Ex06._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valueHasBeenFound = false;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        valueHasBeenFound = true;
                        break;
                    }
                }
            }
            // More code here
            if (valueHasBeenFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
