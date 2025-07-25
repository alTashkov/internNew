
class Program
{
    static void Main(string[] args)
    {
        double x1 = 0;
        double y1 = 0;
        double radius = 2;
        
        Console.Write("Enter x coordinate: ");
        double x2 = double.Parse(Console.ReadLine());
        while (x2 < -1000 || x2 > 1000)
        {
            Console.WriteLine("x coordinate must be in the [-1000;1000] range!");
            Console.Write("Please re-enter x coordinate: ");
            x2 = double.Parse(Console.ReadLine());
        }
        
        
        Console.Write("Enter y coordinate: ");
        double y2 = double.Parse(Console.ReadLine());
        while (y2 < -1000 || y2 > 1000)
        {
            Console.WriteLine("y coordinate must be in the [-1000;1000] range!");
            Console.Write("Please re-enter y coordinate: ");
            y2 = double.Parse(Console.ReadLine());
        }
        

        double distance = Math.Pow((Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)),0.5);
        distance = Math.Round(distance, 2);

        bool isInside = (distance <= radius);
        
        Console.Write(isInside ? "yes" : "no");
        Console.WriteLine($" {distance}");
    }
}
