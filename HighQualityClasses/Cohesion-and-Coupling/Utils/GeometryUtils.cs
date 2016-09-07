namespace CohesionAndCoupling
{
    using System;

    public class GeometryUtils
    {
        /// <summary>
        /// Calculate distance in 2D surface by diven coordinates points. Using Math.Sqrt(); methd.
        /// </summary>
        /// <param name="firstXPoint">double firstXPoint</param>
        /// <param name="firstYPoint">double firstYPoint</param>
        /// <param name="secondXPoint">double secondXPoint</param>
        /// <param name="secondYPoint">double secondYPoint</param>
        /// <returns>Calculated distance as double number.</returns>
        public static double CalculateDistance2D(double firstXPoint, double firstYPoint, double secondXPoint, double secondYPoint)
        {
            double distance = Math.Sqrt(((secondXPoint - firstXPoint) * (secondXPoint - firstXPoint)) + ((secondYPoint - firstYPoint) * (secondYPoint - firstYPoint)));
            
            return distance;
        }

        /// <summary>
        /// Calculate distance in 3D surface by diven coordinates points. Using Math.Sqrt(); methd.
        /// </summary>
        /// <param name="firstXPoint">double firstXPoint</param>
        /// <param name="firstYPoint">double firstYPoint</param>
        /// <param name="firstZPoint">double firstZPoint</param>
        /// <param name="secondXPoint">double secondXPoint</param>
        /// <param name="secondYPoint">double secondYPoint</param>
        /// <param name="secondZPoint">double secondZPoint</param>
        /// <returns>Calculated distance as double number.</returns>
        public static double CalculateDistance3D(double firstXPoint, double firstYPoint, double firstZPoint, double secondXPoint, double secondYPoint, double secondZPoint)
        {
            double distance = Math.Sqrt(((secondXPoint - firstXPoint) * (secondXPoint - firstXPoint)) + ((secondYPoint - firstYPoint) * (secondYPoint - firstYPoint)) + ((secondZPoint - firstZPoint) * (secondZPoint - firstZPoint)));
            
            return distance;
        }
    }
}
