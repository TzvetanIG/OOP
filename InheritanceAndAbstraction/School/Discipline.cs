using System;
using System.Collections.Generic;
using System.Linq;

class Discipline : School
{
    private string name;
    private int numberOfLectures;
    private IList<Student> students = new List<Student>();

    public Discipline(string name, int numberOfLectures)
    {
        this.NumberOfLectures = numberOfLectures;
        this.Name = name;
    }

    public Discipline(string name, int numberOfLectures, IList<Student> students)
        : this(name, numberOfLectures)
    {
        this.students = students;
    }

    public string Name
    {
        get { return name; }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The name must not to be empty or null.", "name");
            }

            this.name = value;
        }
    }

    public int NumberOfLectures
    {
        get { return this.numberOfLectures; }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("THe number of lecture must be integer number greater than zero.");
            }

            this.numberOfLectures = value;
        }
    }

    public void AddStudent(Student student)
    {
        this.students.Add(student);
    }

    public override string ToString()
    {
        return "Дисциплина: " + this.Name + "\n  " + 
            string.Join("  ", this.students.Select(s => s.ToString() + "\n").ToArray());
    }
}

