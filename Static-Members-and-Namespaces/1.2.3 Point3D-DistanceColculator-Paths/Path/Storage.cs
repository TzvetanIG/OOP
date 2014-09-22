using System;
using System.IO;
using System.Text.RegularExpressions;

static class Storage
{
    public static void SavePathInFile(string fileName, Path path)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.Write(path);
        }

    }

    public static Path LoadPathOfFile(string fileName)
    {
        Path path = new Path();

        using (StreamReader sr = new StreamReader(fileName))
        {
            string input = sr.ReadToEnd();

            string pattern = "{([\\d,.]+), ([\\d,.]+), ([\\d,.]+)}";

            var reg = new Regex(pattern);
            var matchs = reg.Matches(input);

            if (matchs.Count <= 0)
            {
                throw new ApplicationException("Invalid data in file " + fileName);
            }

            foreach (Match match in matchs)
            {
                double x = double.Parse(match.Groups[1].Value);
                double y = double.Parse(match.Groups[2].Value);
                double z = double.Parse(match.Groups[3].Value);

                Point p = new Point(x, y, z);
                path.AddPoint(p);
            }
        }

        return path;
    }
}

