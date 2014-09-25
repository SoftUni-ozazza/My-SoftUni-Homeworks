using System;

namespace Space3D
{

    public static class DistanceCalculator
    {
        public static double CalcDistance(Point3D p1, Point3D p2)
        {
            double dX = p2.X - p1.X;
            double dY = p2.Y - p1.Y;
            double dZ = p2.Z - p1.Z;
            double distance = Math.Sqrt((dX * dX) + (dY * dY) + (dZ * dZ));
            return distance;
        }        
    }
}
