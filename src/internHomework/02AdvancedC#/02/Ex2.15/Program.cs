class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter HTML: ");
        string html = Console.ReadLine();
        string aTagBegin = "<a href=\"";

        html = html.Replace(aTagBegin, "[URL=");
        html = html.Replace("\">", "]");
        html = html.Replace("</a>", "[/URL]");

        Console.WriteLine();
        Console.Write(html);

        
    }
}