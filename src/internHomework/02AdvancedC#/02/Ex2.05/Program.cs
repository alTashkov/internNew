class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        string[] subs = input.Split(' ');

        string startingTag = "<upcase>";
        string closingTag = "</upcase>";

        int startIndex = 0;
        int endIndex = 0;
        string stringToChange = "";

        for (int i = 0; i < subs.Length; i++)
        {
            startIndex = input.IndexOf(startingTag, startIndex + i);

            if (startIndex == -1)
            {
                break;
            }

            endIndex = input.IndexOf(closingTag, startIndex + startingTag.Length);

            if (endIndex == -1)
            {
                break;
            }

            stringToChange = input.Substring(startIndex + startingTag.Length, endIndex - (startIndex + startingTag.Length));
            input = input.Replace(stringToChange, stringToChange.ToUpper());
        }

        input = input.Replace(startingTag, "");
        input = input.Replace(closingTag, "");
        Console.WriteLine(input);

    }
}