class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter amount of cols: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix;
        matrix = new int[rows, cols];

        string[] numbersNoWhiteSpace; ;

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Row {i+1}");
            Console.Write("Enter numbers: ");

            string input = Console.ReadLine();
            char[] whitespace = new char[] { ' ', '\t' };

            numbersNoWhiteSpace = input.Split(whitespace);

            for (int j = 0; j < numbersNoWhiteSpace.Length; j++)
            {
                matrix[i, j] = int.Parse(numbersNoWhiteSpace[j].ToString());
            }

            Console.WriteLine();
        }



        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }

        int sum = 0;

        if (rows == 3 && cols == 3)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(sum);

        }
        else
        {
            int sliceX = 3;
            int sliceY = 3;

            int maxSum = int.MinValue;

            for (int i = 0; i <= rows - sliceY; i++)
            {
                for (int j = 0; j <= cols - sliceX; j++)
                {
                    int sum3x3 = 0;

                    for (int z = i; z < i + sliceY; z++)
                    {
                        for (int k = j; k < j + sliceX; k++)
                        {
                            sum3x3 += matrix[z, k];
                        }
                    }

                    if (sum3x3 > maxSum)
                    {
                        maxSum = sum3x3;
                    }
                }
            }

            Console.WriteLine("Max 3x3 sum is: " + maxSum);
        }

    }
}