class Program
{
    static void Main()
    {
        string filePATH = "../../../stringInput.txt";

        List<string> strings = new List<string>();

        using (StreamReader sr = new StreamReader(filePATH))
        {
            while (!sr.EndOfStream)
            {
                strings.Add(sr.ReadLine());
            }
        }

        strings.Sort();

        string outputPath = "../../../stringOutput.txt";

        File.WriteAllLines(outputPath, strings);
    }
}