class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../../noLinesFile.txt"))
        {
            int line = 1;
            using (StreamWriter writer = new StreamWriter("../../../fileWithLineNumbers.txt"))
            {
                while (!reader.EndOfStream)
                {
                    writer.WriteLine(line++ + $". {reader.ReadLine()}");
                }
            }
            
        }
    }

}