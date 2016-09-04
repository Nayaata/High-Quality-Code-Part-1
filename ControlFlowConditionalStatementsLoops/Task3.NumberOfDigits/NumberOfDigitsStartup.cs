namespace Task3.NumberOfDigits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class NumberOfDigitsStartup
    {
        static void Main()
        {
            int numberOfPages = int.Parse(Console.ReadLine());

            long numberOfDigits = 0;

            for (int index = 1; index <= numberOfPages; index++)
            {
                index = Math.Abs(index);

                var isIndexInRangeOne = 10 <= index && index < 100;
                var isIndexInRangeTwo = 100 <= index && index < 1000;
                var isIndexInRangeThree = 1000 <= index && index < 10000;
                var isIndexInRangeFour = 10000 <= index && index < 100000;

                if (index < 10)
                {
                    numberOfDigits++;
                }
                else
                {
                    if (isIndexInRangeOne)
                    {
                        numberOfDigits += 2;
                    }
                    else if (isIndexInRangeTwo)
                    {
                        numberOfDigits += 3;
                    }
                    else if (isIndexInRangeThree)
                    {
                        numberOfDigits += 4;
                    }
                    else if (isIndexInRangeFour)
                    {
                        numberOfDigits += 5;
                    }
                    else
                    {
                        numberOfDigits += 6;
                    }
                }
            }

            Console.WriteLine(numberOfDigits);
        }
    }
}

/* shortest solve for current task
            int N = int.Parse(Console.ReadLine());
            int D = 0;

            for (int i = 1; i <= N; i++)
            {
                int currentPage = i;
                while (currentPage > 0)
                {
                    D++;
                    currentPage /= 10;
                }
            }

            Console.WriteLine(D);
*/