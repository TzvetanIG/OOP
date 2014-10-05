using System;
using System.Data;

namespace BankAccount
{
    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(decimal balance, decimal interest, Customer customer)
            : base(balance, interest, customer)
        {
        }

        public void WithdrawSum(decimal sum)
        {
            Validation.CheckForNegativeNumber(sum, "sum");

            if (this.Balance < sum)
            {
                throw new ArithmeticException("Insufficient amount.");
            }

            this.Balance = -sum;

        }

        public override decimal CalculateInterest(int periodByMonths)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(periodByMonths);
        }
    }
}
