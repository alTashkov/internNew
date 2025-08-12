using System.Text.Unicode;

class Program
{
    static void Main()
    {
        using(StreamReader reader = new StreamReader("../../../TODO.txt"))
        {
            int step = 1;
            while (!reader.EndOfStream)
            {
                if (step % 2 != 0)
                {
                    Console.WriteLine(reader.ReadLine());
                }
                else
                {
                    reader.ReadLine();
                }
                step++;
                
            }
            
        }
    }
}