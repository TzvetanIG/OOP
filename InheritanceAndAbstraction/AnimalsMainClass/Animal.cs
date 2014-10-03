public enum Genter
{
    Femail,
    Male
}

public abstract class Animal : ISound
{
    private string name;
    private int age;
    
    protected Animal(string name, int age, Genter genter)
    {
        this.Genter = genter;
        this.Name = name;
        this.Age = age;
    }

    public Genter Genter { get; private set; }

    public int Age
    {
        get { return this.age; }

        private set
        {
            Validation.CheckForNegativeOrZero(value, "age");
            this.age = value;
        }
    }

    public string Name
    {
        get { return this.name; }

        private set
        {
            Validation.CheckForNullOrEmpty(value, "name");
            this.name = value;
        }
    }

    public override string ToString()
    {
        return string.Format("I am {0}.", (this.Genter + " " + this.GetType()).ToLower());
    }

    public abstract void ProduceSound();
}

