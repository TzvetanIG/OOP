using System;
using System.Text.RegularExpressions;

public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email = null)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age)
        : this(name, age, null)
    {
    }



    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new FormatException("The name can not empty or null.");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("age. Argument must be in rang [1..100]");
            }

            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value != null)
            {
                Regex r = new Regex("@");
                Match match = r.Match(value);
                if (match.Length == 1)
                {
                    this.email = value;
                }
                else
                {
                    throw new FormatException("Invalid email");
                }
            }


        }
    }

    public override string ToString()
    {
        string result;

        if (String.IsNullOrEmpty(this.Email))
        {
            result = String.Format("Name: {0}, Age: {1}", this.Name, this.Age);
        }
        else
        {
            result = String.Format("Name: {0}, Age: {1}, Email: {2}", this.Name, this.Age, this.Email);
        }

        return result;
    }

}

