using System;
using System.Threading;

public class TestTimer
{
    public static void Work1(string str)
    {
        Console.Write(str);
    }

    public static void Work2(string str)
    {
        Console.Beep();
    }



    static void Main()
    {
        AsyncTimer timer1 = new AsyncTimer(Work1, 1000, 10000);
        timer1.Start();

        AsyncTimer timer2 = new AsyncTimer(Work2, 500, 20000);
        timer2.Start();
    }
}
