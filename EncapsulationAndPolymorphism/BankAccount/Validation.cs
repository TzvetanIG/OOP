using System;

namespace BankAccount
{
    public static class Validation
    {
        public static void CheckForEmtyOrNull(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The " + paramName + " should not be empty or null.", paramName);
            }
        }

        public static void CheckForNegativeNumber(decimal value, string paramName)
        {
            if (value < 0)
            {
                throw new ArgumentException("The " + paramName + " should be positive number.", paramName);
            }
        }

        internal static void CheckForNull(object value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName, "The " + paramName + " should be not null.");
            }

        }
    }
}
