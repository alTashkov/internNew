class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");

        int number = int.Parse(Console.ReadLine());
        while (number > 100)
        {
            Console.WriteLine("Number must be less than 100!");
            Console.Write("Please re-enter the number: ");
            number = int.Parse(Console.ReadLine());
        }

        bool isPrime;

        int count = 0;

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                    //Console.WriteLine($"{number} % {i} = {number % i}");
                }
            }

            isPrime = count == 2 ? true : false;
        }
        else
        {
            isPrime = false;
        }
        
        Console.WriteLine(isPrime);

    }
}
