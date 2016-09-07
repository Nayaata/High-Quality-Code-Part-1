namespace CohesionAndCoupling
{
    using System;

    public class Paralelepiped
    {       
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
                    throw new ArgumentException("Depth cannot be less than or equal to 0.");
                }

                this.depth = value;
            }
        }

        /// <summary>
        /// Calculate the volume of the paralelepiped, using math formula.
        /// </summary>
        /// <returns>Calculate volume as double number.</returns>
        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            
            return volume;
        }

        /// <summary>
        /// Calculate the diagonal distance XYZ of the paralelepiped.
        /// </summary>
        /// <returns>Calculated distance as double number.</returns>
        public double CalculateDiagonalXYZ()
        {
            double distance = GeometryUtils.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            
            return distance;
        }

        /// <summary>
        /// Calculate the diagonal distance XY of the paralelepiped.
        /// </summary>
        /// <returns>Calculated distance as double number.</returns>
        public double CalculateDiagonalXY()
        {
            double distance = GeometryUtils.CalculateDistance2D(0, 0, this.Width, this.Height);
            
            return distance;
        }

        /// <summary>
        /// Calculate the diagonal distance XZ of the paralelepiped.
        /// </summary>
        /// <returns>Calculated distance as double number.</returns>
        public double CalculateDiagonalXZ()
        {
            double distance = GeometryUtils.CalculateDistance2D(0, 0, this.Width, this.Depth);
            
            return distance;
        }

        /// <summary>
        /// Calculate the diagonal distance YZ of the paralelepiped.
        /// </summary>
        /// <returns>Calculated distance as double number.</returns>
        public double CalculateDiagonalYZ()
        {
            double distance = GeometryUtils.CalculateDistance2D(0, 0, this.Height, this.Depth);
            
            return distance;
        }
    }
}
