namespace Task2.Busses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BussesStartup
    {
        static void Main()
        {
            int c = int.Parse(Console.ReadLine());

            int groupsCount = 1;

            int firstInLineSpeed = int.Parse(Console.ReadLine());

            for (int index = 0; index < c - 1; index++)
            {
                int currentBusSpeed = int.Parse(Console.ReadLine());

                if (currentBusSpeed <= firstInLineSpeed)
                {
                    groupsCount++;

                    firstInLineSpeed = currentBusSpeed;
                }
            }

            Console.WriteLine(groupsCount);
        }
    }
}

/* second try to solve the problem

            int c = int.Parse(Console.ReadLine());

            int groupCount = 1;

            //var list = new List<double>();
            var speeds = new int[c];

            for (int i = 0; i < c; i++)
            {
                //list.Add(number);
                speeds[i] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < speeds.Length - 1; index++)
            {

                if (speeds[index] < speeds[index + 1])
                {
                    continue;
                }
                else if (speeds[index] == speeds[index + 1])
                {
                    groupCount++;
                }
                else
                {
                    groupCount++;
                }
            }

            Console.WriteLine(groupCount);
*/