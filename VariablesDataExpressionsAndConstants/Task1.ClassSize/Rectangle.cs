namespace Task1.ClassSize
{
    using System;
    public class Rectangle
    {
        private double width;
        private double height;


        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Hegiht = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (this.width <= 0)
                {
                    throw new ArgumentException("Width cannot be equal or less than zero!");
                }

                this.width = value;
            }
        }
        public double Hegiht
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (this.height <= 0)
                {
                    throw new ArgumentException("Height cannot be equal or less than zero!");
                }

                this.height = value;
            }
        }

        public static Rectangle GetRotatedSize(Rectangle rectangle, double angleOfRotation)
        {
            double angleOfRotationCosinus = Math.Abs(Math.Cos(angleOfRotation));
            double angleOfRotationSinus = Math.Abs(Math.Sin(angleOfRotation));

            double currentWidth = (angleOfRotationSinus * rectangle.width) + (angleOfRotationCosinus * rectangle.height);
            double currentHeight = (angleOfRotationCosinus * rectangle.width) + (angleOfRotationSinus * rectangle.height);

            Rectangle rotatedRect = new Rectangle(currentWidth, currentHeight);

            return rotatedRect;
        }
    }
}
