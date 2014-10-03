using System.Collections.Generic;
using System.Linq;

class Class
{
    private string textIdentifier;
    private IList<Teacher> teachers = new List<Teacher>();

    public Class(string textIdentifier)
    {
        this.textIdentifier = textIdentifier;
    }

    public Class(string textIdentifier, IList<Teacher> teachers)
        : this(textIdentifier)
    {
        this.teachers = teachers;
    }

    public void AddTeacher(Teacher teacher)
    {
        this.teachers.Add(teacher);
    }

    public override string ToString()
    {
        return "Клас " + this.textIdentifier + "\n" +
            string.Join("\n", this.teachers.Select(t => t.ToString()).ToArray()) + "\n";
    }
}

