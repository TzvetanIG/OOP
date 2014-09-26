using System;

public delegate void ChangedPropartyEventHandler(object sender, PropertyChangedEventArgs e);

public class Student
{
    private string name;
    private int age;
    public event ChangedPropartyEventHandler PropertyChanged;

    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.PropertyChanged += this.GetMessage;
    }

    public int Age
    {
        get { return this.age; }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The age must not to be negative or 0.");
            }

            var ev = new PropertyChangedEventArgs { OldAge = this.age, Age = value, ChangedProperty = "Age" };
            this.age = value;
            this.OnChanged(this, ev);
        }
    }

    public string Name
    {
        get { return this.name; }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The name must not to be null or empty string.");
            }

            var ev = new PropertyChangedEventArgs { OldName = this.name, Name = value, ChangedProperty = "Name" };
            this.name = value;
            this.OnChanged(this, ev);
        }
    }

    protected virtual void OnChanged(object sender, PropertyChangedEventArgs e)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(sender, e);
        }
    }

    private void GetMessage(object sender, PropertyChangedEventArgs e)
    {
        switch (e.ChangedProperty)
        {
            case "Name":
                Console.WriteLine("Property changed: Name (from {1} to {0}).", e.Name, e.OldName);
                break;
            case "Age":
                Console.WriteLine("Property changed: Age (from {1} to {0}).", e.Age, e.OldAge);
                break;
        }
    }
}

