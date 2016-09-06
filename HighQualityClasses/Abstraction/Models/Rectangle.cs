namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private const string InvalidWidth_ExceptionMessage = "Width cannot be less than or equal to 0.";
        private const string InvalidHeight_ExceptionMessage = "Height cannot be less than or equal to 0.";
        
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
                    throw new ArgumentException(InvalidWidth_ExceptionMessage);
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
                    throw new ArgumentException(InvalidHeight_ExceptionMessage);
                }
                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
