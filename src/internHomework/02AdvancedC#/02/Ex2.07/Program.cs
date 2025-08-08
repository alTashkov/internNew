class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter string to encode: ");
        string textToEncOrDec = Console.ReadLine();

        Console.Write("Enter key: ");
        string cipherString = Console.ReadLine();

        char[] cipher = cipherString.ToCharArray();
        
        string encodedText = EncodeDecode(textToEncOrDec, cipher);
        Console.WriteLine($"Encoded text: {encodedText}");

        string decodedText = EncodeDecode(encodedText, cipher);
        Console.WriteLine($"Decoded text: {decodedText}");
    }

    static string EncodeDecode(string s, char[] cipher)
    {
        char[] charsToEncode = s.ToCharArray();

        for (int i = 0; i < s.Length; i++)
        {
            int cipherIndex = i % cipher.Length;

            charsToEncode[i] = (char)(charsToEncode[i] ^ cipher[cipherIndex]);
        }

        string encodedText = new string(charsToEncode);
        return encodedText;
    }
}