namespace Task2.RefactorCSharp2Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    class MessagesStartup
    {
        //1.read the input
        //1.1. first line - receive the first number
        //1.2. secon line - receive the operation (subtraction or addition) -/+
        //1.3. third line - receive the second number
        //2.convert the number to its decimal value
        //3.do the given operation (subtraction or addition)
        //4.convert the result to the given numeral system
        //5.print the result

        static int GetMessageNumbers(string input)
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

                default: throw new ArgumentException();
            }

        }

        static string ConvertMessageToNumber(string input)
        {
            int position = input.Length / 3 - 1;
            string result = string.Empty;

            for (int i = 0; i < input.Length; i += 3)
            {
                string currentDigit = input.Substring(i, 3);
                result += GetMessageNumbers(currentDigit);
                position--;
            }

            return result;
        }

        static void Main()
        {
            var firstMsgNumber = ConvertMessageToNumber(Console.ReadLine());
            var operationSign = Console.ReadLine();
            var secondMsgNumber = ConvertMessageToNumber(Console.ReadLine());

            var firstNumber = BigInteger.Parse(firstMsgNumber);
            var secondNumber = BigInteger.Parse(secondMsgNumber);

            BigInteger resultFromOperation = 0;

            if (operationSign == "+")
            {
                resultFromOperation = firstNumber + secondNumber;
            }
            else if (operationSign == "-")
            {
                resultFromOperation = firstNumber - secondNumber;
            }

            var result = resultFromOperation.ToString();

            result = result.Replace("0", "cad")
                           .Replace("1", "xoz")
                           .Replace("2", "nop")
                           .Replace("3", "cyk")
                           .Replace("4", "min")
                           .Replace("5", "mar")
                           .Replace("6", "kon")
                           .Replace("7", "iva")
                           .Replace("8", "ogi")
                           .Replace("9", "yan");

            Console.WriteLine(result);
        }


    }
}
