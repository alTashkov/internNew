using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Ex4._01
{
    public static class StringExtensions
    {
        /// <summary>
        /// Hashes a string's value using the MD5 algorithm. 
        /// </summary>
        /// <returns>
        /// The hashed string.
        /// </returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the string converted to hexadecimal format.
            return builder.ToString();
        }

        /// <summary>
        /// Converts a <b>string</b> to <b>boolean</b> if it contains a valid value.
        /// </summary>
        /// <returns>
        /// The <b>boolean</b> value of the string.
        /// </returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts a <b>string</b> to <b>short</b> format.
        /// </summary>
        /// <returns>
        /// The <b>short</b> value of the string.
        /// </returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts a <b>string</b> to <b>int</b> format.
        /// </summary>
        /// <returns>
        /// The <b>int</b> value of the string.
        /// </returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts a <b>string</b> to <b>long</b> format.
        /// </summary>
        /// <returns>
        /// The <b>long</b> value of the string.
        /// </returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);

            return longValue;
        }

        /// <summary>
        /// Extracts the date time value of a string.
        /// </summary>
        /// <returns>
        /// The date time value, extracted from the string.
        /// </returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);

            return dateTimeValue;
        }

        /// <summary>
        /// Capitalizes the first letter of a string.
        /// </summary>
        /// <returns>
        /// The string with it's first letter capitalized.
        /// </returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            // Check if the string is valid.
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Extracts a string that exists between substrings of given input. 
        /// </summary>
        /// <returns>
        /// A new string from the input within the given bounds.
        /// </returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);

            startFrom = 0;

            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            // Set the start position based on the length of the starting string.
            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            // Set the end position based on the previously calculated start position.
            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts the cyrillic letters in a string to their latin representations. 
        /// </summary>
        /// <returns>
        /// The converted string acquired from input.
        /// </returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };

            // Look for cyrillic letters that have latin representations
            // within the string array and replace them.
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts the latin letters in a string to their cyricllic representations. 
        /// </summary>
        /// <returns>
        /// The converted string acquired from input.
        /// </returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            // Look for latin letters that have cyrillic representations
            // within the string array and replace them.
            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts a username in cyrillic letters to its latin representation. 
        /// </summary>
        /// <returns>
        /// The converted string acquired from input.
        /// </returns>
        public static string ToValidUsername(this string input)
        {
            // Convert the username to latin to allow Regex replacement use.
            input = input.ConvertCyrillicToLatinLetters();
            
            // Replace the characters within the username,
            // which match the pattern, with empty characters.
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts a file name in cyrillic letters to its latin representation. 
        /// </summary>
        /// <returns>
        /// The converted string acquired from input.
        /// </returns>
        public static string ToValidLatinFileName(this string input)
        {
            // Convert the file name to latin to allow Regex replacement use.
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();

            // Replace the characters within the file name,
            // which match the pattern, with empty characters.
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Extracts the first n characters from a string. 
        /// </summary>
        /// <returns>
        /// The extracted substring with n characters.
        /// </returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            // Extract the substring by finding correct length
            // from comparison between the two variables.
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Extracts the extension of given file. 
        /// </summary>
        /// <returns>
        /// The extracted file extension.
        /// </returns>
        public static string GetFileExtension(this string fileName)
        {
            // Check if file name is valid.
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            // Split the extension and name part of the file name.
            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);

            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Converts file extension to content type. 
        /// </summary>
        /// <returns>
        /// The converted extension if content type exists and is valid.
        /// </returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            // Return non-specific generic binary type
            // if no corresponding key is found.
            return "application/octet-stream";
        }

        /// <summary>
        /// Converts <b>string</b> to <b>byte</b> array. 
        /// </summary>
        /// <returns>
        /// A new <b>byte</b> array.
        /// </returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];

            // Copy all the bytes of the generated char array from the input
            // to the newly created byte array.
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);

            return bytesArray;
        }
    }
}
