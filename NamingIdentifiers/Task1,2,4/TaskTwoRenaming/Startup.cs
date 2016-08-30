namespace People
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var personalNumber = int.Parse(Console.ReadLine());

            var human = Human.HumanFactory(personalNumber);
        }
    }
}
