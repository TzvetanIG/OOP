using System.Runtime.InteropServices;

namespace CompanyHierarchy.Person
{
    public class Customer : Person, ICustomer
    {
        public Customer(string firstName, string lastName, int id, decimal netPurchaseAmount)
            : base(firstName, lastName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        private decimal NetPurchaseAmount { get; set; }

        public void AddAmount(decimal newAmount)
        {
            this.NetPurchaseAmount += newAmount;
        }
    }
}

