namespace Task3.RefactorTheLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        public static void Main()
        {
            const int Dev_Number = 666;

            var number = int.Parse(Console.ReadLine());
            var array = new int [number];

            for (int index = 0; index < 100; index++)
            {
                var expectedValue = array[array.Length - 1];

                if (index % 10 == 0 && array[index] == expectedValue)
                {
                    index = Dev_Number;

                    Console.WriteLine("Value Found");

                }
                else
                {
                    Console.WriteLine(array[index]);
                }
            }
        }
    }
}
