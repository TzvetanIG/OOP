namespace BankAccount
{
    class CompanyCustomer : Customer
    {
        private string bulstat;

        public CompanyCustomer(string name, string bulstat)
            : base(name)
        {
            this.Bulstat = bulstat;
        }

        public string Bulstat
        {
            get { return this.bulstat; }

            private set
            {
                Validation.CheckForEmtyOrNull(value, "bulstat");
                this.bulstat = value;
            }
        }
    }
}