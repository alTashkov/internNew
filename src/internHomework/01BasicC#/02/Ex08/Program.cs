class Program
{

    static void Main(string[] args)
    {
        string s = "\u00A9";
        int tabs = 0;
        byte spaces = 0;
        byte rows = 4;

        for (int i = 0; i < rows + 1; i++)
        {
            tabs = (rows + 1) - i;

            for (int k = 0; k < tabs; k++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                if (!(i == 3 & j == 1))
                {
                    Console.Write(s);
                }
                else
                {
                    Console.Write(" ");
                }


                if (j < 3)
                {
                    Console.Write(" ");
                    spaces++;
                }

            }

            Console.WriteLine("\n");
        }
    }
}
