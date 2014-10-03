using System;

public class People : School
{
    private string name;

    public People(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The name must not to be empty or null.", "name");
            }

            this.name = value;
        }
    }

    public override string ToString()
    {
        return this.Name;
    }
}

