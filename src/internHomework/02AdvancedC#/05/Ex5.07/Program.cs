class Program
{
    static void Main()
    {

        string filePath = "../../../replaceSubs.txt";//large file test name 100MB_exercise

        string stringToBeRemoved = "start";
        string stringToBeAdded = "finish";
        
        string contents = File.ReadAllText(filePath);

        contents = contents.Replace(stringToBeRemoved, stringToBeAdded);

        File.WriteAllText(filePath, contents);
    }
}