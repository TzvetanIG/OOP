using System;

public struct Fraction
{
    private long denominator;

    public Fraction(long numerator, long denominator)
        : this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
        this.Gcd();
    }

    public long Numerator { get; set; }

    public long Denominator
    {
        get { return this.denominator; }

        private set
        {
            if (value == 0)
            {
                throw new DivideByZeroException("The denominator must not to be zero!");
            }

            if (value < 0)
            {
                value *= -1;
                this.Numerator *= -1;
            }

            this.denominator = value;
        }
    }

    public void Gcd()
    {
        long a = this.Numerator;
        long b = this.Denominator;
        while (b != 0)
        {
            long t = b;
            b = a % b;
            a = t;
        }

        this.Numerator = this.Numerator / a;
        this.Denominator = this.Denominator / a;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        checked
        {
            long newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            long newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        checked
        {
            long newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            long newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
    }

    public override string ToString()
    {
        return ((double)this.Numerator / this.Denominator).ToString();
    }

    public string Print()
    {
        if (this.Numerator == 0)
        {
            return "" + 0;
        }

        if (this.Denominator == 1)
        {
            return "" + this.Numerator;
        }

        return this.Numerator + "/" + this.Denominator;
    }
}

