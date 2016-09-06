namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        private const string InvalidRadius_ExceptionMessage = "Radius cannot be less than or equal to 0.";
        
        private double radius;

        public Circle(double radius) 
            : base()
        {
            this.Radius = radius;
        }

        public double Radius 
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException(InvalidRadius_ExceptionMessage);
                }

                this.radius = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }
    }
}
