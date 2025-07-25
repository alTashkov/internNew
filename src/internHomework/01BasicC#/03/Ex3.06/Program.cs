class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number in {abcd} format: ");
        string number = Console.ReadLine();

        if (number.Length != 4 || (number.ToCharArray())[0] == 0)
        {
            Console.WriteLine("Input must be exactly 4 digits and should not start with a 0.");
            return;
        }

            int sum = 0;

        string reverseNumber = new string(number.Reverse().ToArray());

        char[] temp = number.ToCharArray();
        char last = temp[number.Length - 1];

        char[] firstLast = new char[number.Length];

        for (int i = 1; i < number.Length; i++)
        {
            firstLast[i] = temp[i - 1];
        }
        firstLast[0] = last;

        char[] secondThird = number.ToCharArray();
        secondThird[1] = (number.ToCharArray())[2];
        secondThird[2] = (number.ToCharArray())[1];

        for (int i = 0; i < number.Length; i++)
        {
            sum += int.Parse(number[i].ToString());
        }

        Console.WriteLine(sum);
        Console.WriteLine(reverseNumber);
        Console.WriteLine(new string(firstLast));
        Console.WriteLine(new string(secondThird));

    }
}
