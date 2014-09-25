using System;

public struct Location
{
    private double p1;
    private double p2;

    public Location(double latitude, double longitude, Planet planet) : this()
    {
        this.Latitude = latitude;
        this.Longitude = longitude;
        this.Planet = planet;
    }

    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public Planet Planet { get; set; }

    public override string ToString()
    {
        return String.Format("{0}, {1} - {2}", Latitude, Longitude, Planet);
    }
}

