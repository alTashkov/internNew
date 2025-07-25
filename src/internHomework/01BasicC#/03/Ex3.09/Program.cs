class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        while (a < -500 || a > 500)
        {
            Console.WriteLine("Side a must be in the range [-500;500]!");
            Console.Write("Please re-enter side a: ");
            a = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        while (b < -500 || b > 500)
        {
            Console.WriteLine("Side b must be in the range [-500;500]!");
            Console.Write("Please re-enter side b: ");
            b = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter height h: ");
        double h = double.Parse(Console.ReadLine());
        while (h < -500 || h > 500)
        {
            Console.WriteLine("Height h must be in the range [-500;500]!");
            Console.Write("Please re-enter height h: ");
            h = double.Parse(Console.ReadLine());
        }

        double area = (a + b) / 2 * h;

        Console.WriteLine($"Area: {area:F7}");
    }
}
