namespace Task2.MethodPrintStatistics
{
    using System;
    using System.Linq;

    public class Statistics
    {
        public void PrintStatistics(double[] statisticArray, int count)
        {
            double max = GetMaxValue(statisticArray);
            double min = GetMinValue(statisticArray);
            double average = GetAvgValue(statisticArray);

            Print(max);
            Print(min);
            Print(average);
        }

        private void Print(double valueTpPrint)
        {
            Console.WriteLine("{0:F2}", valueTpPrint);
        }

        private double GetAvgValue(double[] statisticArray)
        {
            var avg = statisticArray.Average();

            return avg;
        }

        private double GetMinValue(double[] statisticArray)
        {
            var min = statisticArray.Min();

            return min;
        }

        private double GetMaxValue(double[] statisticArray)
        {
            double max = statisticArray.Max();

            return max;

        }
    }
}

/* second solve
namespace Task2.MethodPrintStatistics
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] statisticArray, int count)
        {
            double max = GetMaxValue(statisticArray);
            double min = GetMinValue(statisticArray);
            double average = GetAvgValue(statisticArray);

            Print(max);
            Print(min);
            Print(average);
        }

        private double GetAvgValue(double[] statisticArray)
        {
            var sum = 0d;

            for (int index = 0; index < statisticArray.Length; index++)
            {
                sum += statisticArray[index];
            }

            var average = sum / statisticArray.Length;
            return average;
        }

        private double GetMinValue(double[] statisticArray)
        {
            var min = double.MaxValue;

            for (int index = 0; index < statisticArray.Length; index++)
            {
                if (statisticArray[index] < min)
                {
                    min = statisticArray[index];
                }
            }

            return min;
        }

        private double GetMaxValue(double[] statisticArray)
        {
            var max = double.MinValue;

            for (int index = 0; index < statisticArray.Length; index++)
            {
                if (statisticArray[index] > max)
                {
                    max = statisticArray[index];
                }
            }

            return max;
        }

        private void Print(double valueTpPrint)
        {
            Console.WriteLine("{0:F2}", valueTpPrint);
        }
    }
}
 */
