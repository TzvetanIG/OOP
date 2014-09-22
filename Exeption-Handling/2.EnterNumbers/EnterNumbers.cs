using System;

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        int[] numbers = new int[10];
        bool isInvalid = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            do
            {
                try
                {
                    numbers[i] = ReadNumber(start, end);
                    isInvalid = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("The number must to be in range [" + start + ".." + end + "]");
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


