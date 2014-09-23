using System;

class EnterNumbers
{
    static void Main()
    {
        const int start = 1;
        const int end = 100;
        var numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            var isInvalid = false;
            do
            {
                try
                {
                    numbers[i] = ReadNumber(start, end);
                    if (i > 0)
                    {
                        if (numbers[i] <= numbers[i - 1])
                        {
                            throw new ArithmeticException();
                        }
                    }

                    isInvalid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The number must to be in range [" + start + ".." + end + "]");
                    isInvalid = true;
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("The number must be greater than " + numbers[i - 1]);
                    isInvalid = true;
                }
            } while (isInvalid);
        }
    }

    public static int ReadNumber(int start, int end)
    {
        string numberAsString = Console.ReadLine();
        int number = int.Parse(numberAsString);
        if (number < start || number > end)
        {
            throw new FormatException("The number must to be in range [" + start + ".." + end + "]");
        }

        return number;
    }
}


