using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of cols: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        // Input
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Row {i + 1}:");
            string[] elements = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(elements[j]);
            }
        }

        int maxLen = 1;
        int maxNumber = matrix[0, 0];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                int value = matrix[r, c];

                //right
                int len = 1;
                for (int k = c + 1; k < cols && matrix[r, k] == value; k++)
                {
                    len++;
                }
                if (len > maxLen)
                {
                    maxLen = len; 
                    maxNumber = value;
                }

                //down
                len = 1;
                for (int k = r + 1; k < rows && matrix[k, c] == value; k++)
                {
                    len++;
                }
                if (len > maxLen) {

                    maxLen = len; 
                    maxNumber = value;

                }

                //down right
                len = 1;
                for (int k = 1; r + k < rows && c + k < cols && matrix[r + k, c + k] == value; k++)
                {
                    len++;
                }
                if (len > maxLen) { 

                    maxLen = len; 
                    maxNumber = value;

                }

                // down left
                len = 1;
                for (int k = 1; r + k < rows && c - k >= 0 && matrix[r + k, c - k] == value; k++)
                {
                    len++;
                }
                if (len > maxLen) {
                    maxLen = len; 
                    maxNumber = value;
                }
            }
        }

        Console.WriteLine($"Longest sequence length: {maxLen}");
        Console.WriteLine($"Number in longest sequence: {maxNumber}");
    }
}
