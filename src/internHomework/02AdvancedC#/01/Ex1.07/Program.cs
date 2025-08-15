class Program
{
    static int rows, cols;
    static int[,] matrix;
    static bool[,] visited;
    static void Main()
    {
        Console.Write("Enter matrix dimensions (N M): ");
        string[] dimensions = Console.ReadLine().Split(" ");
        rows = int.Parse(dimensions[0]);
        cols = int.Parse(dimensions[1]);

        matrix = new int[rows,cols];
        visited = new bool[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Enter numbers on row #{i+1}: ");
            string[] currentNums = Console.ReadLine().Split(" ");
            for (int j = 0; j < cols; j++)
            {
                matrix[i,j] = int.Parse(currentNums[j]);
            }
        }

        int maxArea = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (!visited[row,col])
                {
                    int area = DepthFirstSearch(row, col, matrix[row, col]);
                    if (area > maxArea)
                        maxArea = area;
                }
            }
        }

        Console.WriteLine("Largest area in matrix: " + maxArea);

    }

    static int DepthFirstSearch(int row, int col, int value)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols)
            return 0;

        if (visited[row, col] || matrix[row, col] != value)
            return 0;

        visited[row, col] = true;
        int area = 1;

        area += DepthFirstSearch(row - 1, col, value); //up
        area += DepthFirstSearch(row + 1, col, value); //down
        area += DepthFirstSearch(row, col - 1, value); //left
        area += DepthFirstSearch(row, col + 1, value); // right

        return area;
    }
}
