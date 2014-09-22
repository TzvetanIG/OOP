using System;
using System.Threading;
using  System.Globalization;

public class Point
{
    private double x;
    private double y;
    private double z;
    private static readonly Point startPoint;

    public double X { get { return this.x; } }
    public double Y { get { return this.y; } }
    public double Z { get { return this.z; } }
    static Point()
    {
        Point.startPoint = new Point(0, 0, 0);
    }

    public Point(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Point StartPoint
    {
        get { return startPoint; }
    }

    public override string ToString()
    {
        string result = "{";
        result += String.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        result += "}";

        return result;
    }
}

