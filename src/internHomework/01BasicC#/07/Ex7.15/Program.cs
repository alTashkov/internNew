class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        bool[] primeFlags = new bool[n+1];

        for (int i = 0; i < primeFlags.Length; i++)
        {
            primeFlags[i] = true;
        }
        
        for (int potentialPrime = 2; Math.Pow(potentialPrime,2) <= n; potentialPrime++)
        {
            if (primeFlags[potentialPrime])
            {
                for (int i = potentialPrime * potentialPrime; i <= n; i+=potentialPrime)
                {
                    primeFlags[i] = false;
                }
            }
            
        }

        List<int> primeNumbers = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (primeFlags[i]) primeNumbers.Add(i);
        }


        for (int i = 0; i < primeNumbers.Count; i++)
        {
            Console.Write(primeNumbers[i] + " ");
        }

        Console.WriteLine();

        int primeNumbersNewSize = 0;

        for (int i = 0; i < primeNumbers.Count; i++)
        {
            if (primeNumbers[i] != 0)
            {
                primeNumbersNewSize++;
            }
        }

        Console.WriteLine("Largest prime from given numbers: " + primeNumbers[primeNumbers.Count - 1]);
    }
}