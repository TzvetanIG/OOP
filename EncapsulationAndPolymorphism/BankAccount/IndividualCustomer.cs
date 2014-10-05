namespace BankAccount
{
    class IndividualCustomer : Customer
    {
        private string egn;

        public IndividualCustomer(string name, string egn) : base(name)
        {
            this.Egn = egn;
        }

        public string Egn
        {
            get { return this.egn; }

            private set
            {
                Validation.CheckForEmtyOrNull(value, "egn");
                this.egn = value;
            }
        }
    }
}
