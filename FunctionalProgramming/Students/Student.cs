namespace Students
{
    using System.Collections;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                Validation.CheckForNullOrEmptyString(value, "FirstName");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            private set
            {
                Validation.CheckForNullOrEmptyString(value, "LastName");
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            private set
            {
                Validation.CheckForNegativeOrZero(value, "Age");
                this.age = value;
            }
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }

            set
            {
                Validation.CheckForNegativeOrZero(value, "FacultyNumber");
                this.facultyNumber = value;
            }
        }

        public string Phone
        {
            get { return this.phone; }

            private set
            {
                Validation.CheckForNullOrEmptyString(value, "Phone");
                this.phone = value;
            }
        }

        public string Email
        {
            get { return this.email; }

            private set
            {
                Validation.CheckForNullOrEmptyString(value, "Email");
                Validation.CheckEmail(value, "Email");
                this.email = value;
            }
        }

        public IList<int> Marks
        {
            get { return this.marks; }

            private set
            {
                Validation.CheckForNull(value, "Marks");
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }

            private set
            {
                Validation.CheckForNegativeOrZero(value, "Age");
                this.groupNumber = value;
            }
        }


    }
}
