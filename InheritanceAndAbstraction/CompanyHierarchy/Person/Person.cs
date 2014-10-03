namespace CompanyHierarchy.Person
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Person(string firstName, string lastName, int id)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Id = id;
        }

        public int Id
        {
            get { return this.id; }

            set
            {
                Validation.CheckForNegativeOrZero(value, "id");
                this.id = value;
            }
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
                Validation.CheckForNullOrEmpty(value, "firstName");
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - ID: {2}", this.FirstName, this.LastName, this.Id);
        }
    }
}

