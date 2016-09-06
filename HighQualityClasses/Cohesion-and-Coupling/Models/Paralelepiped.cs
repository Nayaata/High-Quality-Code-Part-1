namespace CohesionAndCoupling
{
    using System;

    public class Paralelepiped
    {
        private const string InvalidWidth_ExceptionMessage = "Width cannot be less than or equal to 0.";
        private const string InvalidHeight_ExceptionMessage = "Height cannot be less than or equal to 0.";
        private const string InvalidDepth_ExceptionMessage = "Depth cannot be less than or equal to 0.";
        
        private double width;
        private double height;
        private double depth;

        public Paralelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
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

        public double Depth
        {
            get
            {
                return this.depth;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidDepth_ExceptionMessage);
                }
            }
        }

        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            
            return volume;
        }

        public double CalculateDiagonalXYZ()
        {
            double distance = CalculateUtils.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            
            return distance;
        }

        public double CalculateDiagonalXY()
        {
            double distance = CalculateUtils.CalculateDistance2D(0, 0, this.Width, this.Height);
            
            return distance;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = CalculateUtils.CalculateDistance2D(0, 0, this.Width, this.Depth);
            
            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = CalculateUtils.CalculateDistance2D(0, 0, this.Height, this.Depth);
            
            return distance;
        }
    }
}
