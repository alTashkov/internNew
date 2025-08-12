class Program
{
    static void Main()
    {
        var contents = File.ReadAllText("../../../file2.txt");
        File.AppendAllText("../../../file1.txt", "\r\n" + contents);
        File.AppendAllText("../../../bothFiles.txt",File.ReadAllText("../../../file1.txt"));
    }
}