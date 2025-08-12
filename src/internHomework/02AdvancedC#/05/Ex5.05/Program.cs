class Program
{
    static void Main()
    {
        string filePATH = "../../../inputFile.txt";
        string resultFilePATH = "../../../resultFile.txt";

        int lineNum = 1;
        int rows = 0;
        int cols = 0;

        List<string> numbers = new List<string>();

        using (StreamReader sr = new StreamReader(filePATH))
        {
            while (!sr.EndOfStream)
            {
                if (lineNum == 1)
                {
                    rows = int.Parse(sr.ReadLine());
                    cols = rows;
                }
                else
                {
                    numbers.Add(sr.ReadLine());
                }
                lineNum++;
            }
        }

        string[] currentRowSubString = new string[rows-1];
        int[,]matrix = new int[rows,cols];
        int currentRow = 0;

        foreach (string number in numbers)
        {
            currentRowSubString = number.Split(" ");
            for (int i = 0; i < currentRowSubString.Length; i++)
            {
                matrix[currentRow,i] = int.Parse(currentRowSubString[i]);
            }
            currentRow++;
        }

        int largestTwoByTwoSum = int.MinValue;

        for (int i = 0; i <= rows - 2; i++)
        {
            int currentTwoByTwoSum = 0;

            for (int j = 0; j <= cols - 2; j++)
            {
                currentTwoByTwoSum = matrix[i,j] + matrix[i, j+1] + matrix[i+1,j] + matrix[i+1,j+1];

                if (largestTwoByTwoSum < currentTwoByTwoSum)
                {
                    largestTwoByTwoSum = currentTwoByTwoSum;
                }
            }
        }

        Console.WriteLine(largestTwoByTwoSum);
    }
}