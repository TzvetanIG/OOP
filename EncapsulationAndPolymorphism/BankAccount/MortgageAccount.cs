namespace BankAccount
{
    using System;

    class MortgageAccount : Account
    {
        public MortgageAccount(decimal balance, decimal yearInterestInPercent, Customer customer)
            : base(balance, yearInterestInPercent, customer)
        {
        }

        public override decimal CalculateInterest(int periodByMonths)
        {
            var halfInterestMonths = 0;
            switch (this.Customer.GetType().Name)
            {
                case "IndividualCustomer":
                    halfInterestMonths = 6;
                    break;
                case "CompanyCustomer":
                    halfInterestMonths = 12;
                    break;
                default:
                    throw new NotImplementedException("There is not this case.");
            }

            var fullInterestMonths = periodByMonths - halfInterestMonths;

            if (fullInterestMonths <= 0)
            {
                return base.CalculateInterest(halfInterestMonths) / 2;
            }

            return base.CalculateInterest(halfInterestMonths) / 2 + base.CalculateInterest(fullInterestMonths);
        }
    }
}
