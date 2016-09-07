namespace Task2.RefactorCSharp2Exam
{
    using System;

    internal class Message
    {
        /// <summary>
        /// Cnvert given string message to its number representation.
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>Converted input string as number, otherwise throws ArgumentException.</returns>
        internal static int GetMessageToNumbers(string input)
        {
            switch (input)
            {
                case "cad": return 0;
                case "xoz": return 1;
                case "nop": return 2;
                case "cyk": return 3;
                case "min": return 4;
                case "mar": return 5;
                case "kon": return 6;
                case "iva": return 7;
                case "ogi": return 8;
                case "yan": return 9;

                default: throw new ArgumentException("Invalid input!");
            }

        }

        /// <summary>
        /// Convert given string message to number in given numeric system.Using GetMessageToNumbers(); method
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>converted input string to number represented as string.</returns>
        internal static string ConvertMessageToNumber(string input)
        {
            int position = input.Length / 3 - 1;
            string result = string.Empty;

            for (int i = 0; i < input.Length; i += 3)
            {
                string currentDigit = input.Substring(i, 3);
                result += GetMessageToNumbers(currentDigit);
                position--;
            }

            return result;
        }
    }
}
