using System;
using System.IO;
using System.Text.RegularExpressions;

static class Storage
{
    public static void SavePathInFile(string fileName, Path path)
    {
        File.WriteAllText(fileName, path.ToString());
    }

    public static Path LoadPathOfFile(string fileName)
    {
        string input = File.ReadAllText(fileName);
        string pattern = "{([\\d,.]+), ([\\d,.]+), ([\\d,.]+)}";

        var reg = new Regex(pattern);
        var matchs = reg.Matches(input);
        Path path = new Path();
        foreach (Match match in matchs)
        {
            double x = double.Parse(match.Groups[1].Value);
            double y = double.Parse(match.Groups[2].Value);
            double z = double.Parse(match.Groups[3].Value);

            Point p = new Point(x, y, z);
            path.AddPoint(p);
        }

        return path;
    }
}

