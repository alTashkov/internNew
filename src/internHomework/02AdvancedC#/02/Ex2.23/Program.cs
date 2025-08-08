class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int idx = 0;
        string[] letters = new string[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            letters[i] = input[i].ToString();
        }

        while (idx < letters.Length - 1)
        {
            if (letters[idx] == letters[idx + 1])
            {
                letters[idx] = "";
            }
            ++idx;

        }

        input = String.Join("",letters);
        Console.WriteLine(input);
    }
}