class Program
{

    static void Main(string[] args)
    {
        string a = "Hello";
        string b = "World";
        object obj = a + " " + b;
        string objStr = obj.ToString() ?? " ";
        Console.WriteLine(objStr);
    }
}
