using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string wordFilePATH = "../../../words.txt";
        string testFilePATH = "../../../test.txt";
        string resultFilePATH = "../../../result.txt";

        string[] words = File.ReadAllLines(wordFilePATH);

        string text = File.ReadAllText(testFilePATH);

        int prev = 0;

        for (int i = 0; i < words.Length; i++)
        {
            int countOfCurrentWord = Regex.Matches(text, words[i]).Count;
            using(StreamWriter writer = new StreamWriter(resultFilePATH, true))
            {
                writer.WriteLine(countOfCurrentWord + " times: " + words[i]);
            }
        }

        string[] resultTextToBeSorted = File.ReadAllLines(resultFilePATH);

        Array.Sort(resultTextToBeSorted);
        Array.Reverse(resultTextToBeSorted);

        using (StreamWriter writer = new StreamWriter(resultFilePATH))
        {
            for (int i = 0; i < resultTextToBeSorted.Length; i++)
            {
                writer.WriteLine($"{resultTextToBeSorted[i]}");
            }
        }
    }
}