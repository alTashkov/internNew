class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("Enter fifth number: ");
        double e = double.Parse(Console.ReadLine());

        double biggest = a;

        //biggest = biggest > b ? biggest : b > biggest ? b : 0;
        //biggest = biggest > c ? biggest : c > biggest ? c : 0;
        //biggest = biggest > d ? biggest : d > biggest ? d : 0;
        //biggest = biggest > e ? biggest : e > biggest ? e : 0;
        if (biggest < b)
        {
            biggest = b;
        }
        if (biggest < c)
        {
            biggest = c;
        }
        if (biggest < d)
        {
            biggest = d;
        }
        if (biggest < e)
        {
            biggest = e;
        }

        Console.WriteLine($"Biggest number of {a},{b},{c},{d},{e} is: {biggest}");
    }
}