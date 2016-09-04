namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// This class contains extension methods of string.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a string into an MD5 hash, which is a 32-character string of hexadecimal numbers.
        /// </summary>
        /// <param name="input">The input string that should be converted.</param>
        /// <returns>String of hexadecimal numbers.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Checks if an input string contains another string values from a given collection.
        /// </summary>
        /// <param name="input">The input string that needs to be checked.</param>
        /// <returns>True if the string contains given values from collection, otherwise, false.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Tries to convert an input string to short.
        /// </summary>
        /// <param name="input">The input string that should be converted.</param>
        /// <returns>A short representation of the input string, otherwise System.ArgumentException is thrown when parsing has not succeeded.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Tries to convert an input string to integer.
        /// </summary>
        /// <param name="input">The input string that should be converted.</param>
        /// <returns>An integer representation of the input string, otherwise System.ArgumentException is thrown when parsing has not succeeded.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Tries to convert an input string to long.
        /// </summary>
        /// <param name="input">The input string that should be converted.</param>
        /// <returns>A long representation of the input string, otherwise System.ArgumentException is thrown when parsing has not succeeded.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Tries to convert an input string to DateTime.
        /// </summary>
        /// <param name="input">The input string that should be converted.</param>
        /// <returns>A DateTime representation of the input string, otherwise System.ArgumentException is thrown when parsing has not succeeded.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalizes the first letter of an input string
        /// </summary>
        /// <param name="input">The input string that should be converted.</param>
        /// <returns>String with a capitalized first letter, otherwise if given string is null or empty, current method return the input string.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Get some substring of an input string by given positions.
        /// </summary>
        /// <param name="input">The input string from wich get the substring.</param>
        /// <param name="startString">The startString param is the start point for the substring.</param>
        /// <param name="endString">The endString param is the end point for the current substring.</param>
        /// <param name="startFrom">The int startFrom param is the starting index.</param>
        /// <returns>Substring (between startString and andString) of given input string.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;

            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;

            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);

            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Convert all Cyrillic letters of an input string to their Latin letters representation.
        /// </summary>
        /// <param name="input">The input string that should be converted.</param>
        /// <returns>Converted input string with Latin letters.</returns>
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
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Convert Latin letters of an input string to their Cyrillic Keyboard letters representation.
        /// </summary>
        /// <param name="input">The input string that should be converted.</param>
        /// <returns>Converted input string with Cyrillic Keyboard letters</returns>
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

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary> 
        /// Convert all Cyrillic letters of an input string to their Latin letters representation, check for valid username and replace forbidden characters.
        /// </summary>
        /// <param name="input">The input string that should be validated.</param>
        /// <returns>Validated username as string.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Convert all Cyrillic letters of an input string to their Latin letters representation and check for valid file name.
        /// </summary>
        /// <param name="input">The input string that should be validated.</param>
        /// <returns>Validated file name as string.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Get the substring of first char of given input string.
        /// </summary>
        /// <param name="input">The input string that should be used.</param>
        /// <param name="charsCount">Int charsCount represent the total count of chars in given string.</param>
        /// <returns>First char of given input string as single char string.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Get file extension of given fileName string (input).
        /// </summary>
        /// <param name="fileName">String fileName representing a file path.</param>
        /// <returns>File extension as string, otherwise return empty string.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);

            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Convert file extension string into file content type of given file extension string by creating new Dictionary.
        /// </summary>
        /// <param name="fileExtension">File extension string that should be converted.</param>
        /// <returns>Content type matched to the given file extension.</returns>
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

            return "application/octet-stream";
        }

        /// <summary>
        /// Convert input string into byte Array.
        /// </summary>
        /// <param name="input">The input string that should be converted.</param>
        /// <returns>Converted string as new byte Array.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}