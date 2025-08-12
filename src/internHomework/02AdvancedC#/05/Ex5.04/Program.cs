class Program
{
    static void Main()
    {
        string fileOnePath = "../../../file1.txt";
        string fileTwoPath = "../../../file2.txt";

        List<string> lines1 = File.ReadAllLines(fileOnePath).ToList(); 

        int sameLinesCount = 0;

        foreach (string line in File.ReadLines(fileTwoPath))
        {
            if (lines1.Contains(line))
            {
                sameLinesCount++;
            }
        }

        Console.WriteLine(sameLinesCount);
    }
}