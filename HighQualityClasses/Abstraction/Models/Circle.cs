namespace Abstraction
{
    using System;

    public class Circle : Figure
    {     
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
                    throw new ArgumentException("Radius cannot be less than or equal to 0.");
                }

                this.radius = value;
            }
        }

        /// <summary>
        /// Calculate the circle perimeter by given radius. Using Math formula and the constant PI.
        /// </summary>
        /// <returns>Claculated perimeter as double number.</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        /// <summary>
        /// Calculate the circle surface by given radius. Using Math formula and the constant PI.
        /// </summary>
        /// <returns>Claculated surface as double number.</returns>
        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }
    }
}
