using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        string text = "The space race captivated the world in the following decades. On 12.04.1961, Soviet cosmonaut Yuri Gagarin became the first human to journey into outer space. This was followed by another monumental achievement on 20.07.1969, when American astronaut Neil Armstrong became the first person to walk on the moon. The century closed with the reunification of Germany on 03.10.1990, a symbol of the end of the Cold War.";

        string[] subString = text.Split(' ');
        string formatString = "dd.MM.yyyy";

        for (int i = 0; i < subString.Length - 1; i++)
        {
            DateTime date;
            if (DateTime.TryParseExact(subString[i].TrimEnd(','), formatString, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
            {
                Console.WriteLine(subString[i].TrimEnd(',') + " in Canadian format: " + date.ToString("yyyy.MM.dd"));
            }
        }
    }
}