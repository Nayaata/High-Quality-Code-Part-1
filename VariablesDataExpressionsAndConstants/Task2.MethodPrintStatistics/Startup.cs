namespace Task2.MethodPrintStatistics
{
    class Startup
    {
        static void Main()
        {
            double[] numbers = new double[] { 18.2, -19.0, 5.4, 4.5, 0.0, 30.2, -10.9, 150.5 };

            var statistics = new Statistics();

            statistics.PrintStatistics(numbers, numbers.Length);

        }
    }
}
