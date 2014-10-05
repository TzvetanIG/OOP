using System;

namespace BankAccount
{
    public abstract class Customer
    {
        private string name;

        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                Validation.CheckForEmtyOrNull(value, "name");
                this.name = value;
            }
        }
    }
}
