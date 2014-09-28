namespace Students
{
    class StudentSpecialty
    {
        private int facultyNumber;
        private string specialties;

        public StudentSpecialty(int facultyNumber, string specialties)
        {
            this.Specialties = specialties;
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }

            set
            {
                Validation.CheckForNegativeOrZero(value, "facultyNumber");
                this.facultyNumber = value;
            }
        }

        public string Specialties
        {
            get { return this.specialties; }

            set
            {
                Validation.CheckForNullOrEmptyString(value, "Specialties");
                this.specialties = value;
            }
        }
    }
}
