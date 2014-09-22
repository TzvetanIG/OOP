using System;

class TestBitArray
{
    static void Main()
    {
        BitArray num = new BitArray(8);
        num[0] = 1;
        num[7] = 1;
        Console.WriteLine(num);
    }
}

