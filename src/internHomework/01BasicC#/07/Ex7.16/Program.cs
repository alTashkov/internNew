using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
 
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            int num = int.Parse(Console.ReadLine());

            numbers[i] = num;
            
        }

        int[] lengthAtEachIndex = new int[n];

        for (int i = 0; i < n; i++)
        {
            lengthAtEachIndex[i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] <= numbers[i] && lengthAtEachIndex[j] + 1 > lengthAtEachIndex[i])
                {
                    lengthAtEachIndex[i] = lengthAtEachIndex[j] + 1;
                }
            }
        }

        int LIS = 0;
        for (int i = 0; i < lengthAtEachIndex.Length; i++)
        {
            if (lengthAtEachIndex[i] > LIS)
            {
                LIS = lengthAtEachIndex[i];
            }
        }

        //Console.WriteLine();

        //for (int z = 0; z < lengthAtEachIndex.Length; z++) 
        //{
        //    Console.Write(lengthAtEachIndex[z] + " ");
        //}

        //Console.WriteLine();

        Console.WriteLine($"Elements to remove: {numbers.Length - LIS}.");
    }
}
