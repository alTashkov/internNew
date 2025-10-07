using System;

namespace Ex5._02
{
    internal class StatisticsPrinter
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double maxValue = arr[0];
            double minValue = arr[0];
            double sumOfValues = 0;

            for (int i = 0; i < count; i++)
            {
                double currentValue = arr[i];

                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }
                
                if (currentValue < minValue)
                {
                    minValue = currentValue;
                }

                sumOfValues += currentValue;
            }

            double averageValue = sumOfValues / count;

            Console.WriteLine("Maximum value: " + maxValue);
            Console.WriteLine("Minimum value: " + minValue);
            Console.WriteLine("Average value: " + averageValue);
        }
    }
}
