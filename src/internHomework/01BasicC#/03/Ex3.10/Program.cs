class Program
{
    static void Main(string[] args)
    {
        double x1 = 1;
        double y1 = 1;
        double radius = 1.5;

        Console.Write("Enter x coordinate: ");
        double x2 = double.Parse(Console.ReadLine());
        while(x2 < -1000 || x2 > 1000)
        {
            Console.WriteLine("X must be in the range [-1000;1000]!");
            Console.Write("Please re-enter x: ");
            x2 = double.Parse(Console.ReadLine());
        }

        Console.Write("Enter y coordinate: ");
        double y2 = double.Parse(Console.ReadLine());
        while (y2 < -1000 || y2 > 1000)
        {
            Console.WriteLine("Y must be in the range [-1000;1000]!");
            Console.Write("Please re-enter y: ");
            y2 = double.Parse(Console.ReadLine());
        }

        bool insideCircle;
        bool insideRectangle;
        
        double distance = Math.Pow((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 0.5);
        
        insideCircle = (distance <= radius);

        double top = 1;
        double left = -1;

        double width = 6;
        double height = 2;

        double bottom = top - height;
        double right = left + width;

        insideRectangle = (x2 >= left && x2 <= right && y2 >= bottom && y2 <= top);

        Console.Write(insideCircle ? "inside circle" : "outside circle");
        Console.Write(insideRectangle ? " inside rectangle" : " outside rectangle");

    }
}
