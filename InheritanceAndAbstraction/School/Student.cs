using System;

class Student : People
{
    private int classNumber;

    public Student(string name, int classNumber)
        : base(name)
    {
        this.classNumber = classNumber;
    }

    public int ClassNumber
    {
        get { return this.classNumber; }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("SchoolClass number must be integer number greater than zero.");
            }

            this.classNumber = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + " - No " + this.ClassNumber;
    }
}

