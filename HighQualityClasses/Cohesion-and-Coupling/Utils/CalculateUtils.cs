namespace CohesionAndCoupling
{
    using System;

    public class CalculateUtils
    {
        public static double CalculateDistance2D(double firstXPoint, double firstYPoint, double secondXPoint, double secondYPoint)
        {
            double distance = Math.Sqrt(((secondXPoint - firstXPoint) * (secondXPoint - firstXPoint)) + ((secondYPoint - firstYPoint) * (secondYPoint - firstYPoint)));
            
            return distance;
        }

        public static double CalculateDistance3D(double firstXPoint, double firstYPoint, double firstZPoint, double secondXPoint, double secondYPoint, double secondZPoint)
        {
            double distance = Math.Sqrt(((secondXPoint - firstXPoint) * (secondXPoint - firstXPoint)) + ((secondYPoint - firstYPoint) * (secondYPoint - firstYPoint)) + ((secondZPoint - firstZPoint) * (secondZPoint - firstZPoint)));
            
            return distance;
        }
    }
}
