namespace Task1.QualityMethods.Utils
{
    using System;
    using Task1.QualityMethods.Enumerations;

    internal class MethodCalculation
    {
        /// <summary>
        /// Calculate triangle area by given three sides, using maths formulas and calculation of the area is with Math.Sqrt
        /// </summary>
        /// <param name="sideA">double sideA is the first of the given sides</param>
        /// <param name="sideB">double sideB is the second given side</param>
        /// <param name="sideC">double sideC is the third given side</param>
        /// <returns>The area of the triangle as double number, otherwise throws ArgumentException</returns>
        internal static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive!");
            }

            double semiperimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));

            return area;
        }

        /// <summary>
        /// Convert given digit to its word representation using switch-case statements
        /// </summary>
        /// <param name="number">int number is the input digit</param>
        /// <returns>Digit as word, otherwise throws ArgumentException</returns>
        internal static string ConvertDigitToWordRepresentation(int number)
        {
            switch (number)
            {
                case 0:
                    {
                        return "zero";
                    }
                case 1:
                    {
                        return "one";
                    }
                case 2:
                    {
                        return "two";
                    }
                case 3:
                    {
                        return "three";
                    }
                case 4:
                    {
                        return "four";
                    }
                case 5:
                    {
                        return "five";
                    }
                case 6:
                    {
                        return "six";
                    }
                case 7:
                    {
                        return "seven";
                    }
                case 8:
                    {
                        return "eight";
                    }
                case 9:
                    {
                        return "nine";
                    }

                default:
                    {
                        throw new ArgumentException("Invalid digit!");
                    }
            }
        }

        /// <summary>
        /// Find the maximum value in given int collection of elements
        /// </summary>
        /// <param name="elements"></param>
        /// <returns>The value of the max element, otherwise if the element is null or empty throws ArgumentNullException</returns>
        internal static int FindMaxValueInCollection(params int[] elements)
        {
            var length = elements.Length;

            if (elements == null || length == 0)
            {
                throw new ArgumentNullException("There should be at least one argument!");
            }

            int maxNumber = int.MinValue;

            for (int index = 1; index < length; index++)
            {
                maxNumber = Math.Max(maxNumber, elements[index]);
            }

            return elements[0];
        }

        /// <summary>
        /// Print given number as formatted string. Using switch-case statement and enumeration types for every different format.
        /// </summary>
        /// <param name="number">object number is the input number.</param>
        /// <param name="format">FormatType format is the input format.</param>
        internal static void PrintNumberAsFormattedString(object number, FormatType format)
        {
            switch (format)
            {
                case FormatType.Round:
                    {
                        Console.WriteLine("{0:f2}", number);
                        break;
                    }
                case FormatType.Percent:
                    {
                        Console.WriteLine("{0:p0}", number);
                        break;
                    }
                case FormatType.AlignRight:
                    {
                        Console.WriteLine("{0,8}", number);
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Invalid format!");
                    }
            }
        }

        /// <summary>
        /// Get the line position by given coordinates points. Using enumeration types for the different line positions.
        /// </summary>
        /// <param name="firstPointX">double firstPointX</param>
        /// <param name="firstPointY">double firstPointY</param>
        /// <param name="secondPointX">double secondPointX</param>
        /// <param name="secondPointY">double secondPointY</param>
        /// <returns></returns>
        internal static Position GetLinePosition(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            if (firstPointX == secondPointX && firstPointY == secondPointY)
            {
                return Position.OverlapedPoints;
            }
            else if (firstPointX == secondPointX)
            {
                return Position.Vertical;
            }
            else if (firstPointY == secondPointY)
            {
                return Position.Horizontal;
            }
            else
            {
                return Position.Other;
            }
        }

        /// <summary>
        /// Calculate the distan
        /// </summary>
        /// <param name="firstPointX">double firstPointX</param>
        /// <param name="firstPointY">double firstPointY</param>
        /// <param name="secondPointX">double secondPointX</param>
        /// <param name="secondPointY">secondPointY</param>
        /// <returns>The calculated distance az double number.</returns>
        internal static double CalculateDistanceBetweenPoints(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double productX = (secondPointX - firstPointX) * (secondPointX - firstPointX);
            double productY = (secondPointY - firstPointY) * (secondPointY - firstPointY);

            double distance = Math.Sqrt(productX + productY);

            return distance;
        }
    }
}
