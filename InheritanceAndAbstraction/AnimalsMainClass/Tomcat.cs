class Tomcat : Cat
{
    public Tomcat(string name, int age)
        : base(name, age, Genter.Male)
    {
    }

    public override string ToString()
    {
        return string.Format("I am a {0} cat.", this.Genter.ToString().ToLower());
    }
}

