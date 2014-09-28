using System;

public static class Validation
{
    public static void CheckForNegativeOrZero(decimal value, string argumentName)
    {
        if (value <= 0)
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

    public static void CheckEmail(string email, string argumentName)
    {
        if (!email.Contains("@"))
        {
            throw new ArgumentException("Invalid email.", argumentName);
        }
    }

    public static void CheckForNull(object value, string argumentName)
    {
        if (value == null)
        {
            throw new ArgumentException("The argument must not to be null.", argumentName);
        }
    }
}

