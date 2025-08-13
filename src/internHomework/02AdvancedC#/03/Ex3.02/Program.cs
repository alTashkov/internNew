class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> nums = new List<int>();

            int prev = 1;

            for (int i = 0; i < 10; i++)
            {
                int number = ReadNumber(prev, 100);
                nums.Add(number);
                prev = number;
            }

            Console.Write("1 ");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write("< " + nums[i] + " ");
            }
            Console.Write("< 100");
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message.ToString());
        }
        
    }
    static int ReadNumber(int start, int end)
    {
        Console.Write($"Enter number between {start} and {end}: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            throw new FormatException("Not a number");
        }

        if (number <= start || number >= end)
        {
            throw new Exception("Number not in valid range!");
        }
        
        return number;
        
    }
}


