class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of rows/cols: ");
        int n = int.Parse(Console.ReadLine());

        while (n < 1 || n > 20)
        {
            Console.Write("Invalid number! \n Must be [1;20].\nPlease re-enter the number: ");
            n = int.Parse(Console.ReadLine());
        }

        int number = 1;
        int left = 0;
        int top = 0;
        int bottom = n - 1;
        int right = n - 1;

        int[,] spiral = new int[n, n];

        while (number <= n * n)
        {
            //l to r
            for (int i = left; i<=right && number <= n*n; i++)
            {
                spiral[top,i] = number++;
            }
            top++;

            //t to b
            for (int i = top; i<=bottom && number <= n*n; i++)
            {
                spiral[i, right] = number++;
            }
            right--;

            //r to l
            for (int i = right; i>=left && number <= n*n; i--)
            {
                spiral[bottom, i] = number++;
            }
            bottom--;

            //b to t
            for (int i = bottom; i >= top && number <= n*n; i--)
            {
                spiral[i, left] = number++;
            }
            left++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiral[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}