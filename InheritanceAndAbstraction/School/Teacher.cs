using System.Collections.Generic;
using System.Linq;

class Teacher : People
{
    private IList<Discipline> disciplines = new List<Discipline>();

    public Teacher(string name)
        : base(name)
    {
    }

    public Teacher(string name, IList<Discipline> disciplines)
        : base(name)
    {
        this.disciplines = disciplines;
    }

    public void AddDiscipline(Discipline discipline)
    {
        this.disciplines.Add(discipline);
    }

    public override string ToString()
    {
        return base.ToString() + "\n  " +
            string.Join("\n  ", this.disciplines.Select(d => d.ToString()).ToArray());
    }
}

