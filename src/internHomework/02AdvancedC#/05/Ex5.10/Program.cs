using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "../../../extractWithoutTags.xml";
        string pattern = "<[^>]*>";

        string contents = File.ReadAllText(filePath);

        Regex re = new Regex(pattern);

        string result = re.Replace(contents, " ");

        result = Regex.Replace(result.Trim(), @"\s+", " ");

        Console.WriteLine(result);

        
    }
}