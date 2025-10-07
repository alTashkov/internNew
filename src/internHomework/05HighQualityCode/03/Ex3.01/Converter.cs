using System;

namespace Ex3._01
{
    internal class BoolToStringConverter
    {
        const int maxCount = 6;

        internal class Converter
        {
            public void Convert(bool boolToConvert)
            {
                string boolAsString = boolToConvert.ToString();

                Console.WriteLine(boolAsString);
            }
        }

        public static void DoConversion()
        {
            BoolToStringConverter.Converter instance =
                new BoolToStringConverter.Converter();

            instance.Convert(true);
        }
    }
}
