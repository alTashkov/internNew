class Program
{

    static void Main(string[] args)
    {
        Console.Write("First floating-point number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Second floating-point number: ");
        double b = double.Parse(Console.ReadLine());

        double eps = 0.000001;

        bool areEqual = Math.Abs(a - b) < eps;
        Console.WriteLine(areEqual); 
        
    }
}
