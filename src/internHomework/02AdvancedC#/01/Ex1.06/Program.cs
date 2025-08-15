using System.Text;

class Matrix
{
    private readonly int[,] matrix;
    public int Rows { get; }
    public int Columns { get; }
    public Matrix(int rows, int columns)
    {
        if (rows <= 0 || columns <= 0)
        {
            throw new ArgumentException("Each dimension must be greater than 0!");
        }

        this.Rows = rows;
        this.Columns = columns;
        this.matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                this.matrix[i, j] = 0;
            }
        }
    }

    public Matrix(int[,] matrix)
    {
        Rows = matrix.GetLength(0);
        Columns = matrix.GetLength(1);
        this.matrix = matrix;
    }    
    public static Matrix operator + (Matrix left, Matrix right)
    {
        Matrix added = new Matrix(left.Rows, right.Columns);

        for (int i = 0; i < left.Rows; i++)
        {
            for (int j = 0; j < right.Rows; j++)
            {
                added.matrix[i,j] = left.matrix[i,j] + right.matrix[i,j];
            }
        }

        return added;
    }

    public static Matrix operator -(Matrix left, Matrix right)
    {
        Matrix subtracted = new Matrix(left.Rows, right.Columns);

        for (int i = 0; i < left.Rows; i++)
        {
            for (int j = 0; j < right.Rows; j++)
            {
                subtracted.matrix[i, j] = left.matrix[i, j] - right.matrix[i, j];
            }
        }

        return subtracted;
    } 
    public static Matrix operator * (Matrix left, Matrix right)
    {
        Matrix multiplied = new Matrix(left.Rows, right.Columns);
        for (int i = 0; i < left.Rows; i++)
        {
            for (int j = 0; j < right.Columns; j++)
            {
                for (int k = 0; k < left.Columns; k++)
                {
                    multiplied.matrix[i, j] += left.matrix[i, k] * right.matrix[k, j];
                }
                
            }
        }
        return multiplied;
    }

    public int this[int row, int column]
    {
        get
        {
            if (row < 0 || column < 0 || row > this.Rows || column > this.Columns)
            {
                throw new ArgumentOutOfRangeException("Index is out of range!");
            }
            return matrix[row, column];
        }
        set
        {
            if (row < 0 || column < 0 || row > this.Rows || column > this.Columns)
            {
                throw new ArgumentOutOfRangeException("Index is out of range!");
            }
            matrix[row, column] = value;
        }
    }
    public override string ToString()
    { 
        var matrixString = new StringBuilder();
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                matrixString.Append(matrix[i,j] + " ");
            }
            matrixString.AppendLine();
        }

        return matrixString.ToString();
    }
}
class Program
{
    static void Main()
    {
        int[,] firstMatrix = {
          {1, 2, 3},
          {4, 5, 6},
          {7, 8, 9}
        };

        int[,] secondMatrix = {
          {9, 8, 7},
          {6, 5, 4},
          {3, 2, 1}
        };

        Matrix matrix1 = new Matrix(firstMatrix);
        Matrix matrix2 = new Matrix(secondMatrix);

        Matrix matrixAdded = matrix1 + matrix2;
        Console.WriteLine("Matrices added: ");
        Console.WriteLine(matrixAdded);

        Matrix matrixSubtracted = matrix1 - matrix2;
        Console.WriteLine("Matrices subtracted: ");
        Console.WriteLine(matrixSubtracted);

        Matrix matrixMultiplied = matrix1 * matrix2;
        Console.WriteLine("Matrices multiplied: ");
        Console.WriteLine(matrixMultiplied);

        Console.WriteLine("Second element of first matrix: " + matrix1[0, 1]);

    }
}
