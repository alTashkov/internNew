using _4._02;

struct Point3D
{
    public double x, y, z;
    private static readonly Point3D centerPoint = new Point3D(0,0,0);
    public Point3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public Point3D(string pathInStringFormat)
    {
        List<double> currentPoint = new List<double>();
        for (int i = 0; i < pathInStringFormat.Length; i++)
        {
            if (currentPoint.Count >= 3)
            {
                break;
            }
            if (!double.TryParse(pathInStringFormat[i].ToString(),out double a))
            {
                continue;
            }
            currentPoint.Add(a);
        }

        if (currentPoint.Count > 0)
        {
            double x = currentPoint[0];
            double y = currentPoint[1];
            double z = currentPoint[2];

            this.x = x;
            this.y = y;
            this.z = z;
        }
        
    }
    public override string ToString()
    {
        return $"[{this.x},{this.y},{this.z}]";
    }

    public static Point3D CenterPoint
    {
        get { return centerPoint; }
    }
}

class Program
{
    static void Main()
    {
        Point3D p1;
        p1.x = 3;
        p1.y = 4;
        p1.z = 5;

        Point3D p2 = new(5, 1, 2);

        List<Point3D> points = new List<Point3D>();

        points.Add(p1);
        points.Add(p2);

        string filePath = "../../../testPath.txt";

        Path3D path3D = new Path3D(points);

        Path3D path3D2 = new Path3D();

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