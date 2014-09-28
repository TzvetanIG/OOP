


namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ExcelLibrary.SpreadSheet;
    using QiHe.CodeLib;

    public class StudentsTester
    {
        private static void Main()
        {
            // Problem 3. Class Student
            var students = new List<Student>
            {
                new Student("Petar", "Petrov", 19, 123414, "+359 2 77 888 888", "email@gfg.bg", new List<int>{5, 2, 5, 4}, 2),
                new Student("Milka", "Mitreva", 32, 123513, "0885 999 888", "email@abv.bg", new List<int>{6, 6, 6, 6}, 3),
                new Student("Krasi", "Angelov", 38, 123613, "0888 902 888", "email@abv.bg", new List<int>{6, 6, 6, 4}, 2),
                new Student("Dimitar", "Angelov", 38, 123714, "+3592 0888 999 888", "email@abv.bg", new List<int>{6, 6, 6, 4}, 1),
                new Student("Ana", "Asenova", 22, 123813, "0888 999 788", "email@qpp.com", new List<int>{5, 2, 2, 5}, 2),
                new Student("Ana", "Genova", 22, 133913, "02 888 999 788", "email@qpp.com", new List<int>{5, 2, 5,}, 2)
            };

            Console.WriteLine("------------------- Problem 4. Students by Group");
            var selectedStudents = students.Where(s => s.GroupNumber == 2)
                .Select(s => string.Format("{0} {1} - {2}", s.FirstName, s.LastName, s.GroupNumber));
            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            Console.WriteLine("------------------- Problem 5. Students by First and Last Name");
            selectedStudents = students.Where(s => string.Compare(s.FirstName, s.LastName) < 0)
                .Select(s => string.Format("{0} {1}", s.FirstName, s.LastName));
            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            Console.WriteLine("------------------- Problem 6. Students by Age");
            var selectedStudentsByAge = students.Where(s => s.Age >= 18 && s.Age <= 24)
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age });
            foreach (var student in selectedStudentsByAge)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();


            Console.WriteLine("------------------- Problem 7.	Sort Students");
            var sortStudents = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName)
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName });
            foreach (var student in sortStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("-------------");

            var querySortStudents =
                from s in students
                orderby s.FirstName + s.LastName descending
                select new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age };

            foreach (var student in querySortStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine();

            Console.WriteLine("------------------- Problem 8. Filter Students by Email Domain");
            var filterStudentsByEmail = students.Where(s => s.Email.Contains("@abv.bg"))
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Email });
            foreach (var student in filterStudentsByEmail)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            Console.WriteLine("------------------- Problem 9. Filter Students by Phone");
            var filterStudentsByPhone = students
                .Where(
                    s => s.Phone.IndexOf("02") == 0 || s.Phone.IndexOf("+3592") == 0 || s.Phone.IndexOf("+359 2") == 0)
                .Select(s => string.Format("{0} {1} - {2}", s.FirstName, s.LastName, s.Phone));
            foreach (var student in filterStudentsByPhone)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            Console.WriteLine("------------------- Problem 10. Excellent Students");
            var excellentStudents = students
                .Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks })
                .Where(s => s.Marks.IndexOf(6) >= 0);
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(student.FullName);
            }

            Console.WriteLine();

            Console.WriteLine("------------------- Problem 11. Weak Students");
            var weakStudents = students
                .Where(s => s.Marks.Aggregate(0, (counter, mark) => counter + (mark == 2 ? 1 : 0)) == 2)
                .Select(s => s.FirstName + " " + s.LastName);
            foreach (var student in weakStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            Console.WriteLine("------------------- Problem 12.	Students Enrolled in 2014");
            var studentsEnroled2014 = students
                .Where(s => s.FacultyNumber % 100 == 14)
                .Select(s => s.FirstName + " " + s.LastName + " - " + s.FacultyNumber);
            foreach (var student in studentsEnroled2014)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            Console.WriteLine("------------------- 13. Students by Groups");
            var studentsByGroups = students
                .GroupBy(s => s.GroupNumber, (g, s) => s);
            foreach (var studentsGroup in studentsByGroups)
            {
                Console.WriteLine("Group number {0}", studentsGroup.First().GroupNumber);

                foreach (var student in studentsGroup)
                {
                    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("------------------- Problem 14. Students Joined To Specialties");
            var studentSpecialties = new List<StudentSpecialty>
            {
                new StudentSpecialty(123414, "Web Developer"),
                new StudentSpecialty(123513, "PHP Developer"),
                new StudentSpecialty(123613, "QA Engineer"),
                new StudentSpecialty(123714, "QA Engineer"),
                new StudentSpecialty(123813, "Web Developer"),
                new StudentSpecialty(133913, "Web Developer"),
            };

            var studentsJoinedToSpecialties = students
                .Join(studentSpecialties,
                    s => s.FacultyNumber,
                    sp => sp.FacultyNumber,
                    (s, sp) =>
                        new
                        {
                            FullName = s.FirstName + " " + s.LastName,
                            FacultyNumber = s.FacultyNumber,
                            Specialty = sp.Specialties
                        })
                .OrderBy(s => s.FullName);

            foreach (var student in studentsJoinedToSpecialties)
            {
                Console.WriteLine("{0}, {1}, {2}", student.FullName, student.FacultyNumber, student.Specialty);
            }

         }



    }
}
