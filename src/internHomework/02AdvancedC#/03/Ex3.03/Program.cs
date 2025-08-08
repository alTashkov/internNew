class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter full file path: ");
        string filePath = Console.ReadLine();

        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File content: ");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file was not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Error: The directory doesn't exist!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: You don't have permission to access this file!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Error: The file path is too long!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Error: The file path is invalid!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}