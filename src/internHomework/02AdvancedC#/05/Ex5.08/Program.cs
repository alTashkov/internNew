using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "../../../replaceWords.txt";//large file test name 100MB_exercise
        string outputPATH = "../../../replacedWords.txt";

        string stringToBeRemoved = "start";
        string stringToBeAdded = "finish";

        using (StreamReader reader = new StreamReader(filePath))
        {
            using (StreamWriter writer = new StreamWriter(outputPATH))
            {
                string line;
                while (!reader.EndOfStream && (line = reader.ReadLine()) != null)
                {
                    string modifiedWord = Regex.Replace(line,$@"\b{stringToBeRemoved}\b", stringToBeAdded);
                    writer.WriteLine(modifiedWord);
                }
            }
        }
        
    }
}