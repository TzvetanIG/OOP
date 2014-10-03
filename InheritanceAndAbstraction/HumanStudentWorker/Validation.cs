using System;
using System.Text.RegularExpressions;

public static class Validation
{
    public static void CheckForNullOrEmpty(string value, string argumentName)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("The argument must not to be empty or null.", argumentName);
        }
    }

    public static void ChekForValidFacultyNumber(string value, string argumentName)
    {
        CheckForNullOrEmpty(value, argumentName);

        if (value.Length < 5 || value.Length > 10)
        {
            throw new ArgumentException("The argument must to be in range [5..10].", argumentName);
        }

        var regex = new Regex("[\\dA-Za-z]");
        var matches = regex.Matches(value);
        if (value.Length > matches.Count)
        {
            throw new ArgumentException("Invalid argument. Use only digits or letters", argumentName);
        }

    }

    public static void CheckForNegativeOrZero(object number, string argumentName)
    {
        if (double.Parse(number.ToString()) <= 0)
        {
            throw new ArgumentException("The argument must not to be negative or zero.", argumentName);
        }
    }
}

