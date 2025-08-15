class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = { "Test", "Banana", "Spawn", "Apple", "Cucumber", "Bean", "Low" };

        SortStringArray(stringArray);

    }
    static void SortStringArray(string[] stringArray)
    {
        for (int j = 0; j <= stringArray.Length - 1; j++)
        {
            for (int m = 0; m < stringArray.Length - j - 1; m++)
            {
                if (stringArray[m].Length > stringArray[m + 1].Length)
                {
                    string temp = stringArray[m];
                    stringArray[m] = stringArray[m + 1];
                    stringArray[m + 1] = temp;
                }
            }
        }

        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }
    }
}