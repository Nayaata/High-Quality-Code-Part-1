namespace Task1.QualityMethods
{
    using System;
    using Task1.QualityMethods.Enumerations;
    using Task1.QualityMethods.Utils;
    using Task1.QualityMethods.Models;

    internal class MethodStartup
    {
        internal static void Main()
        {
            Console.WriteLine(MethodCalculation.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(MethodCalculation.ConvertDigitToWordRepresentation(5));

            Console.WriteLine(MethodCalculation.FindMaxValueInCollection(5, -1, 3, 2, 14, 2, 3));

            MethodCalculation.PrintNumberAsFormattedString(1.3, FormatType.Round);
            MethodCalculation.PrintNumberAsFormattedString(0.75, FormatType.Percent);
            MethodCalculation.PrintNumberAsFormattedString(2.30, FormatType.AlignRight);

            double firstPointX = 3.0;
            double firstPointY = -1.0;
            double secondPointX = 3.0;
            double secondPointY = 2.5;

            Console.WriteLine(MethodCalculation.CalculateDistanceBetweenPoints(firstPointX, firstPointY, secondPointX, secondPointY));
            Position linePosition = MethodCalculation.GetLinePosition(firstPointX, firstPointY, secondPointX, secondPointY);
            Console.WriteLine("Line position: " + linePosition);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "Sofia");

            Student stella = new Student("Stella", "Markova", new DateTime(1993, 3, 11), "Vidin");
         
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
