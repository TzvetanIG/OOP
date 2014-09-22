using System;


class TestProblems
{
    static void Main()
    {
        //Problem 1. Point3D
        Console.WriteLine("Problem 1. Point3D");
        Console.WriteLine("--------------------");

        Point p1 = new Point(1, 2, 3);
        Point p2 = new Point(3.4, 4.66, 5.55);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(Point.StartPoint);
        Console.WriteLine();

        //Problem 2. Distance Calculator
        Console.WriteLine("Problem 2. Distance Calculator");
        Console.WriteLine("-------------------------------");

        double distance = DistanceCalcolator.CalculateDistance(p1, p2);
        Console.WriteLine(distance);
        Console.WriteLine();

        //Problem 3. Paths
        Console.WriteLine("Problem 3. Paths");
        Console.WriteLine("-------------------------------");

        Path path = new Path(p1, p2, Point.StartPoint);
        Console.WriteLine("Save path: {0}", path);
        Storage.SavePathInFile("path.txt", path);
        Path loadPath = Storage.LoadPathOfFile("path.txt");
        Console.WriteLine("Load path: {0}", loadPath);
    }
}

