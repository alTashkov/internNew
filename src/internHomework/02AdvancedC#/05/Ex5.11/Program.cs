using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePATH = "../../../prefixText.txt";
        //Content of the file I tested: 
        //testone testtwo testthree four five six testseven eight testnine

        string pattern = "\\btest\\w*\\b";

        Regex regex = new Regex(pattern);

        string contents = File.ReadAllText(filePATH);

        contents = regex.Replace(contents, "");
        contents = contents.Trim();

        using (StreamWriter writer = new StreamWriter(filePATH))
        {
            writer.WriteLine(contents);
        }

        //Content of the file I tested after regex replacements: 
        //four five six  eight
    }
}


