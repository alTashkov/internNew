class Program
{
    static void Main(string[] args)
    {
        uint number = uint.Parse(Console.ReadLine());

        string num = Math.Abs(number).ToString();

        if(num.Length < 3)
        {
            Console.WriteLine("false 0");
        }
        else
        {
            char thirdDigit = num[num.Length - 3];
            if(thirdDigit == '7')
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"false {thirdDigit}");
            }
        }
    }
}
