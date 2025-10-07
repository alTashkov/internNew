using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._02
{
    internal class StatisticsPrinter
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double maxValue = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            Console.WriteLine("Maximum value: " + maxValue);

            double minValue = maxValue;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }
            Console.WriteLine("Minimum value: " + minValue);

            double sumOfValues = 0;
            for (int i = 0; i < count; i++)
            {
                sumOfValues += arr[i];
            }
            Console.WriteLine("Average value: " + sumOfValues / count);
        }
    }
}
