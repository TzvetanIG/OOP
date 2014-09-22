using System;

public static class DistanceCalcolator
{
    public static double CalculateDistance(Point p1, Point p2)
    {
        double deltaX = p1.X - p2.X;
        double deltaY = p1.Y - p2.Y;
        double deltaZ = p1.Z - p2.Z;
        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        return distance;
    }

}

