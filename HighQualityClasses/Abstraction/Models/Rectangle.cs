namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {   
        private double width;
        private double height;

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Width cannot be less than or equal to 0.");
                }

                this.width = value;
            }
        }

        public double Height 
        { 
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be less than or equal to 0.");
                }
                this.height = value;
            }
        }

        /// <summary>
        /// Calculate the rectangle perimeter by given width and height. Using Math formula.
        /// </summary>
        /// <returns>Claculated perimeter as double number.</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        /// <summary>
        /// Calculate the rectangle surface by given width and height. Using Math formula.
        /// </summary>
        /// <returns>Claculated surface as double number.</returns>
        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
