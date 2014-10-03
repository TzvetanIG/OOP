using System;
using System.Collections.Generic;
using System.Linq;

class HumanStudentWorker
{
    static void Main()
    {
        IList<Student> students = new List<Student>
        {
            new Student("Peter", "Brown", "abc10005"),
            new Student("Milka", "Ivanova", "vde12346"),
            new Student("Todor", "Geshov", "cwe12347"),
            new Student("Vasil", "Angelov", "abc10001"),
            new Student("Mihail", "Petrov", "nht10200"),
            new Student("Todor", "Genchev", "nth12346"),
            new Student("Ana", "Mihailova", "ggg12346"),
            new Student("Aneta", "Ivanova", "rrr12346"),
            new Student("Angel", "Georgiev", "abc12346"),
            new Student("Boris", "Borisov", "abc10000"),
        };

        IList<Worker> workers = new List<Worker>
        {
            new Worker("Petera", "Brown", 250, 8),
            new Worker("Milkaa", "Ivanova", 250, 8),
            new Worker("Todora", "Geshov", 200, 8),
            new Worker("Vasila", "Angelov", 200, 6),
            new Worker("Mihaila", "Petrov", 350, 8),
            new Worker("Todora", "Genchev", 150, 6),
            new Worker("Ana", "Nikolova", 150, 8),
            new Worker("Anita", "Ivanova", 500, 4),
            new Worker("Angela", "Georgiev", 300, 8),
            new Worker("Boris", "Asenov", 320,8 ),
        };

        var sortedStudentByFacultyNumber = students.OrderBy(s => s.FacultyNumber);
        Console.WriteLine(string.Join("\n", sortedStudentByFacultyNumber.Select(s => s.ToString())));
        Console.WriteLine();

        var sortedWorkerByPaymentPerHour  = workers.OrderByDescending(w => w.MoneyPerHour());
        Console.WriteLine(string.Join("\n", sortedWorkerByPaymentPerHour.Select(w => w.ToString())));
        Console.WriteLine();

        var humans = new List<Human>();
        humans.AddRange(students);
        humans.AddRange(workers);
        var sortHumansByNames = humans
            .OrderBy(h => h.FirstName)
            .ThenBy(h => h.LastName)
            .Select(h => h.FirstName + " " + h.LastName + " - " + h.GetType());

        Console.WriteLine(string.Join("\n", sortHumansByNames));

    }
}

