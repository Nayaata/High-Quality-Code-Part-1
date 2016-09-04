namespace Task1.Feathers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FeathersStartup
    {
        static void Main()
        {
            const long Even_Multiplier = 123123123123;
            const int Odd_Divisor = 317;

            double birdsCount = double.Parse(Console.ReadLine());
            double feathersCount = double.Parse(Console.ReadLine());

            double averageFeathersCount = feathersCount / birdsCount;
            double result = 0;

            if (birdsCount % 2 == 0)
            {
                result = averageFeathersCount * Even_Multiplier;
            }
            else
            {
                result = averageFeathersCount / Odd_Divisor;
            }

            Console.WriteLine("{0:F4}", result);
        }
    }
}
