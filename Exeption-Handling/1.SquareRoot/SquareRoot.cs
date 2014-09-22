using System;

class SquareRoot
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        try
        {
            int number = int.Parse(inputString);
            if (number < 0)
            {
                throw new ArithmeticException();
            }

            double squareRoot = Math.Sqrt(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid nember");
        }
        catch
        {
            Console.WriteLine("Invalid nember");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}

