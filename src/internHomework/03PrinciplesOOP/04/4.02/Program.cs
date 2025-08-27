using _4._02;

internal class Program
{
    static void Main()
    {
        Point3D p1 = new (3,4,5);

        Point3D p2 = new (5, 1, 2);

        List<Point3D> points = [p1, p2];

        string filePath = "../../../testPath.txt";

        Path3D path3D = new(points);

        Path3D path3D2 = new();

        PathStorage.SavePathToFile(path3D, filePath);
        PathStorage.LoadPathFromFile(path3D2, filePath);

        Console.WriteLine(path3D2);

        Matrix<int> matrixInt = new Matrix<int>(3,3);
        Matrix<int> matrixInt2 = new Matrix<int>(3, 3);

        Random rnd = new Random();
        int number = rnd.Next(1, 30);

        Console.WriteLine("Matrix 1: ");

        for (int i = 0; i < 3 ; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrixInt[i, j] = number++;
                Console.Write(matrixInt[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Matrix 2: ");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrixInt2[i, j] = number++;
                Console.Write(matrixInt2[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Result from addition: ");

        Matrix<int> matrixResult = matrixInt + matrixInt2;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrixResult[i, j] + " ");
            }
            Console.WriteLine();
        }

        matrixResult.PrintVersion();

    }
}