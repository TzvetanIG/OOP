namespace BankAccount
{
    public abstract class Account : IInterestColculatable, IDepositable
    {
        private Customer customer;
        private decimal monthInterest;
        private decimal balance;

        protected Account(decimal balance, decimal yearInterestInPercent, Customer customer)
        {
            this.Balance = balance;
            this.MonthInterest = yearInterestInPercent / 12 / 100;
            this.Customer = customer;
        }

        public Customer Customer
        {
            get { return this.customer; }

            private set
            {
                Validation.CheckForNull(value, "customer");
                this.customer = value;
            }
        }

        public decimal MonthInterest
        {
            get { return this.monthInterest; }

            set
            {
                Validation.CheckForNegativeNumber(value, "yearInterest");
                this.monthInterest = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }

            protected set
            {
                Validation.CheckForNegativeNumber(value, "interest");
                this.balance = value;
            }
        }

        public virtual decimal CalculateInterest(int periodByMonths)
        {
            var interstForPeriod = this.balance * this.monthInterest * periodByMonths;
            return interstForPeriod;
        }

        public void DeositSum(decimal sum)
        {
            Validation.CheckForNegativeNumber(sum, "sum");

            this.Balance = +sum;
        }
    }
}
