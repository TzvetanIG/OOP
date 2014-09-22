using System;
using System.Collections.Generic;

class Path
{
    private List<Point> points = new List<Point>();

    public Path(params Point[] points)
    {
        if (points.Length > 0)
        {
            this.points.AddRange(points);
        } 
    }

    public void AddPoint(Point point)
    {
        this.points.Add(point);
    }

    public override string ToString()
    {
         return string.Join(" ", this.points);
    } 
}

