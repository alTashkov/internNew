class Program
{
    static void Main(string[] args)
    {

        string text = "Lorem ipsum dolor sit reyop-uzini44@aol.com, consectetur adipiscing elit. Curabitur non tisom_osusi91@aol.com sapien. Nunc pulvinar posuere tincidunt. In congue posuere massa, sed pellentesque odio semper in. Morbi ut lectus ut augue cursus hendrerit id vel libero. Ut hendrerit, neque et pretium dignissim, lorem felis pellentesque risus, et efficitur libero lectus vel diam. Integer non aliquam orci, at sagittis lectus. In vestibulum dolor eget porta varius. Morbi rutrum est non bibendum sollicitudin. Mauris congue a libero in hendrerit. Fusce dolawa_jipu6@outlook.com ultricies lectus a varius. fax_okonuwa60@hotmail.com per conubia nostra, per inceptos himenaeos. Fusce convallis dictum metus.";

        int emailCount = 0;

        string subOfText = text;

        for (int i = 0; i < text.Length; i++)
        {
            int index = 0;
            index = subOfText.IndexOf('@');
            subOfText = subOfText.Remove(0, index+1);

            if (index > 0)
            {
                emailCount++;
            }
            else
            {
                break;
            }
        }

        string[] subString = text.Split(' ');

        string[] emails = new string[emailCount];

        int emailIdx = 0;
        int subStringIdx = 0;
        
        while (emailCount > 0 || subStringIdx < (subString.Length - 1) )
        {
            if (subString[subStringIdx].Contains("@"))
            {
                emails[emailIdx] = subString[subStringIdx];
                emailCount--;

                Console.WriteLine($"Email {emailIdx+1}: {emails[emailIdx]}");
                emailIdx++;
            }
            subStringIdx++;
        }

        

        
    }
}