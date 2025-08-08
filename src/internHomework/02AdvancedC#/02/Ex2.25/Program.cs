using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        string titleTag = "<title>";
        string titleTagClose = "</title>";

        if (!(text.Contains(titleTag) || !(text.Contains(titleTagClose))))
        {
            return;
        }
        else
        {
            int indexOfTitleOpen = text.IndexOf(titleTag) + titleTag.Length;
            int indexOfTitleClose = text.IndexOf(titleTagClose);

            string title = text.Substring(indexOfTitleOpen, indexOfTitleClose - indexOfTitleOpen);
            Console.WriteLine("Title: " + title);

            string bodyTag = "<body>";
            string bodyTagClose = "</body>";

            int indexOfBodyOpen = text.IndexOf(bodyTag) + bodyTag.Length;
            int indexOfBodyClose = text.IndexOf(bodyTagClose);

            string bodyText = text.Substring(indexOfBodyOpen, indexOfBodyClose - indexOfBodyOpen);

            while (bodyText.Contains("<") && bodyText.Contains(">"))
            {
                int indexOfOpenBracket = bodyText.IndexOf("<");
                int indexOfCloseBracket = bodyText.IndexOf(">");

                if (indexOfOpenBracket != -1 && indexOfCloseBracket != -1)
                {
                    bodyText = bodyText.Remove(indexOfOpenBracket, indexOfCloseBracket - indexOfOpenBracket + 1);

                    bodyText = bodyText.Insert(indexOfOpenBracket, " ");
                }
                else 
                {
                    break;
                }
            }

            Console.WriteLine("Body: " + bodyText);
        }


    }
}