class Program
{
    static async Task Main(string[] args)
    {
        var httpClient = new HttpClient();

        Console.Write("Enter URL: ");
        string url = Console.ReadLine();

        Console.Write("Enter file name with extension to save as: ");
        string userFileName = Console.ReadLine();

        Console.Write("Enter disk drive to save to: ");
        string driveToSaveTo = Console.ReadLine();  

        string folderPath = $@"{driveToSaveTo}:\";
        string fileName = Path.Combine(folderPath, userFileName);

        FileStream fileStream = null;
        Stream httpStream = null;

        try
        {
            Console.WriteLine("Starting download...");

            httpStream = await httpClient.GetStreamAsync(url);

            fileStream = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write);

            await httpStream.CopyToAsync(fileStream);

            Console.WriteLine($"File downloaded successfully at '{fileName}'.");
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("Network error: " + ex.Message);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: No permission to write to this location.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Error: File path is too long.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
        finally
        {
            if (fileStream != null)
                fileStream.Dispose();

            if (httpStream != null)
                httpStream.Dispose();

            if (httpClient != null)
                httpClient.Dispose();
        }
    }
}