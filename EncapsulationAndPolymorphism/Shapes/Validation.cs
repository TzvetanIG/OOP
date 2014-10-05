using System;

namespace Shapes
{
    public static class Validation
    {
        public static void CheckForValidSize(string paramName, double size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(paramName, "The size should be positive number.");
            }
        }

        public static void CheckForValidTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide >= thirdSide + secondSide ||
                secondSide >= thirdSide + firstSide ||
                thirdSide >= firstSide + secondSide)
            {
                throw new ArithmeticException("Invalid triangle's sizes.");
            }
        }
    }
}
