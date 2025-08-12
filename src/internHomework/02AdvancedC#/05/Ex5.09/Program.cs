class Program
{
    static void Main()
    {
        string filePATH = "../../../deleteOddLines.txt";

        List<string> evenLines = new List<string>();

        using (StreamReader reader = new StreamReader(filePATH))
        {
            int lineNumber = 1;
            string line;
            while (!reader.EndOfStream && (line = reader.ReadLine())!=null)
            {
                if (lineNumber % 2 == 0)
                {
                    evenLines.Add(line);
                }
                lineNumber++;
            }
        }

        using (StreamWriter writer = new StreamWriter(filePATH))
        {
            foreach (string line in evenLines)
            {
                writer.WriteLine(line);
            }
        }
    }
}