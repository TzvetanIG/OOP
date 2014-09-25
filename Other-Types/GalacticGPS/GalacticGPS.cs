using System;

public class GalacticGPS
{
    static void Main()
    {
        var sofiaLocation = new Location(83.220058, 89.22111, Planet.Earth);
        Console.WriteLine(sofiaLocation);
    }
}
