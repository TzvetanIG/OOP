using System;

public static class Validation
{
    public static void CheckForNegativeOrZero(object value, string argumentName)
    {
        if ((decimal)value <= 0)
        {
            throw new ArgumentException("The argument must not to be negative or zero.", argumentName);
        }
    }

    public static void CheckForNullOrEmptyString(string value, string argumentName)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("The argument must not to be empty string or null.", argumentName);
        }
    }

    public static void CheckForEmptyString(string value, string argumentName)
    {
        if (value == "")
        {
            throw new ArgumentException("The argument must not to be empty string.", argumentName);
        }
    }
}

