using System;

namespace BankAccount
{
    public class BankAccountTester
    {
        static void Main()
        {
            Customer petar = new IndividualCustomer("Petar Gigov", "8412316466");
            Customer softUni = new CompanyCustomer("Software University",  "BG25445644");

            Account petarDepositAccount = new DepositAccount(10000, 3.0m, petar);
            Console.WriteLine(petarDepositAccount.CalculateInterest(12).ToString("f2"));
            Console.WriteLine();

            Account petarLoanAccount = new LoanAccount(10000, 12m, petar);
            Console.WriteLine(petarLoanAccount.CalculateInterest(4).ToString("f2"));
            Account softuniLoanAccount = new LoanAccount(10000, 12m, softUni);
            Console.WriteLine(softuniLoanAccount.CalculateInterest(4).ToString("f2"));
            Console.WriteLine();

            Account petarMortgageAccount = new MortgageAccount(10000, 12m, petar);
            Console.WriteLine(petarMortgageAccount.CalculateInterest(12).ToString("f2"));
            Account softUniMortgageAccount = new MortgageAccount(10000, 12m, softUni);
            Console.WriteLine(softUniMortgageAccount.CalculateInterest(12).ToString("f2"));
            Console.WriteLine();
            
        }
    }
}
