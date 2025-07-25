class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your weight: ");

        double W = double.Parse(Console.ReadLine());
        Console.WriteLine($"Weight on Earth: {W}");
        
        double weightOnMoon = 0.17 * W;
        weightOnMoon = Math.Round(weightOnMoon, 2);

        Console.WriteLine($"You would weigh {weightOnMoon} kg on the moon." +
            $"\nYou were never fat, you were only on the wrong planet! :)");
        
    }
}
