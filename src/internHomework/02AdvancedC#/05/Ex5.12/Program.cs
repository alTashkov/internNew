class Program
{
    static void Main()
    {
        string filePATH = "../../../removeWords.txt";
        string wordsPATH = "../../../wordsToRemove.txt";

        try
        {
            string textContent = File.ReadAllText(filePATH);
            string wordsContent = File.ReadAllText(wordsPATH);

            string[] words = wordsContent.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (textContent.Contains(words[i]))
                {
                    textContent = textContent.Replace(words[i], "");
                }
            }

            using (StreamWriter writer = new StreamWriter(filePATH))
            {
                writer.WriteLine(textContent);
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid file path!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have access to this file!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path you provided was too long!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory you provided was not found!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This functionality is not supported!");
        }
        finally
        {
            Console.WriteLine("Words removed successfully!");
        }
        
    }
}