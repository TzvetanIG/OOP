abstract public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.LastName = lastName;
        this.FirstName = firstName;
    }

    public string FirstName
    {
        get { return this.firstName; }

        set
        {
            Validation.CheckForNullOrEmpty(value, "firstName");
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }

        set
        {
            Validation.CheckForNullOrEmpty(value, "LastName");
            this.lastName = value;
        }
    }

    public override string ToString()
    {
        return this.firstName + " " + this.lastName;
    }
}

