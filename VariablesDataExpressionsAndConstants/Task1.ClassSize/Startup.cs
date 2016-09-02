namespace Task1.ClassSize
{
    using System;

    class Startup
    {
        static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var rectangle = new Rectangle(width, height);
        }
    }
}
