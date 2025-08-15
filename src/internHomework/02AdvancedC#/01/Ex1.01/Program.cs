class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of matrix: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Choose way of filling (a,b,c,d): ");

        char wayOfFilling = char.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        switch (wayOfFilling)
        {
            case 'a':
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j > 0)
                        {
                            matrix[i, j] = n + matrix[i, j - 1];
                        }
                        else if (j == 0)
                        {
                            matrix[i, j] = i + 1;
                        }
                        Console.Write(matrix[i, j] + " ");
                        
                    }
                    Console.WriteLine();
                }
                break;
            case 'b':
                int number = n+1;
                for (int i = 0; i < n; i++)
                {
                    for(int j = 0;j < n; j++)
                    {
                        if (j==0)
                        {
                            matrix[i, j] = i+1;
                            Console.Write(matrix[i,j] + " ");
                        }
                        else if (j == 1)
                        {
                            matrix[i, j] = n*2-i;
                            Console.Write(matrix[i, j] + " ");
                        }
                        else
                        {
                           matrix[i, j] = matrix[i, j - 2] + (n * 2);
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                
                break;
            case 'c':
                int num = 1;

                for (int startRow = n - 1; startRow >= 0; startRow--)
                {
                    int r = startRow, c = 0;
                    while (r < n && c < n)
                    {
                        matrix[r, c] = num++;
                        r++; c++;
                    }
                }

                for (int startCol = 1; startCol < n; startCol++)
                {
                    int r = 0, c = startCol;
                    while (r < n && c < n)
                    {
                        matrix[r, c] = num++;
                        r++; c++;
                    }
                }

                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        Console.Write(matrix[r, c]);
                        if (c < n - 1) Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                break;
            case 'd':

                number = 1;
                int left = 0;
                int top = 0;
                int bottom = n - 1;
                int right = n - 1;

                while (number <= n * n)
                {
                    //top to bottom
                    for (int i = top; i <= bottom && number <= n * n; i++)
                    {
                        matrix[i, left] = number++;
                    }
                    left++;

                    //left to right
                    for (int i = left; i <= right && number <= n * n; i++)
                    {
                        matrix[bottom,i] = number++;
                    }
                    bottom--;

                    //bottom to top
                    for (int i = bottom; i >= top && number <= n * n; i--)
                    {
                        matrix[i, right] = number++;
                    }
                    right--;

                    //right to left
                    for (int i = right; i >= left && number <= n * n; i--)
                    {
                        matrix[top,i] = number++;
                    }
                    top++;

                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + " ");

                    }
                    Console.WriteLine();
                }

                break;
        }


    }
}