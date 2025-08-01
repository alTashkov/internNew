class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        double divisionRemainder = 1;

        int powerOfFive = 1;

        int amountOfZeroes = 0;

        while (divisionRemainder >= 1)
        {
            divisionRemainder = n / Math.Pow(5, powerOfFive);
            //Console.WriteLine($"{n} / {Math.Pow(5, powerOfFive)} = {divisionRemainder}");
            
            amountOfZeroes += (int)(divisionRemainder);
            
            powerOfFive++; 
        }

        Console.WriteLine($"Amount of zeroes of {n}!: {amountOfZeroes}");

    }
}