namespace Abstraction
{
    using System;
    using System.Text;

    public class Startup
    {
        static void Main()
        {
            var radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);

            var result = new StringBuilder();

            result.AppendFormat("I am a circle. My perimeter is {0:f2}. My surface is {1:f2}.", circle.CalculatePerimeter(), circle.CalculateSurface());

            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);
            result.AppendFormat("I am a rectangle. My perimeter is {0:f2}. My surface is {1:f2}.", rectangle.CalculatePerimeter(), rectangle.CalculateSurface());

            Console.WriteLine(result.ToString());

        }
    }
}
