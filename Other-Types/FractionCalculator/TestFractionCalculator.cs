using System;

class TestFractionCalculator
{
    static void Main()
    {
        var a = new Fraction(1, 1);
        var b = new Fraction(1, -4);
        var c = a + b;
        Console.WriteLine(c.Print());
        Console.WriteLine(c);
    }
}
