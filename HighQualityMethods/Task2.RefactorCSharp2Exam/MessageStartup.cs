namespace Task2.RefactorCSharp2Exam
{
    using System;
    using System.Numerics;

    public class MessageStartup
    {
        static void Main()
        {
            var firstMsgNumber = Message.ConvertMessageToNumber(Console.ReadLine());
            var operationSign = Console.ReadLine();
            var secondMsgNumber = Message.ConvertMessageToNumber(Console.ReadLine());

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
