namespace BankAccount
{
    using System;

    class LoanAccount : Account
    {
        public LoanAccount(decimal balance, decimal yearInterestInPercent, Customer customer)
            : base(balance, yearInterestInPercent, customer)
        {
        }

        public override decimal CalculateInterest(int periodByMonths)
        {
            var monthsInterestFree = 0;
            switch (this.Customer.GetType().Name)
            {
                case "IndividualCustomer":
                    monthsInterestFree = 3;
                    break;
                case "CompanyCustomer":
                    monthsInterestFree = 2;
                    break;
                default:
                    throw new NotImplementedException("There is not this case.");
            }

            if (periodByMonths <= monthsInterestFree)
            {
                return 0m;
            }

            return base.CalculateInterest(periodByMonths - monthsInterestFree);
        }
    }
}
