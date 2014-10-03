class Kitten : Cat
{
    public Kitten(string name, int age)
        : base(name, age, Genter.Femail)
    {
    }

    public override string ToString()
    {
        return string.Format("I am a {0} cat.", this.Genter.ToString().ToLower());
    }
}

