class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = i * 5;
            Console.WriteLine(nums[i]);
        }
        
        
    }
}