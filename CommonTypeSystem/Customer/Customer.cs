using System;
using System.Collections;
using System.Collections.Generic;

namespace Customer
{
    class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(string firstName, string midleName, string lastName,
            int id, string permanentAddress = null, string email = null, string mobilePhone = null)
        {
            this.FirstName = firstName;
            this.MidleName = midleName;
            this.LastName = lastName;
            this.Id = id;
            this.PermanentAddress = permanentAddress;
            this.Email = email;
            this.MobilePhone = mobilePhone;
            this.Payments = new List<Payment>();
        }

        public string FirstName { get; set; }
        public string MidleName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public IList<Payment> Payments { get; private set; }
        public CustomerType CustomerType { get; private set; }

        public void AddPayment(Payment payment)
        {
            this.Payments.Add(payment);
            var paymetsCount = this.Payments.Count;
            if (paymetsCount <= 1)
            {
                this.CustomerType = CustomerType.OneTime;
            } 
            
            if (paymetsCount >= 2)
            {
                this.CustomerType = CustomerType.Regular;
            }

            if (paymetsCount >= 5)
            {
                this.CustomerType = CustomerType.Golden;
            }

            if (paymetsCount >= 8)
            {
                this.CustomerType = CustomerType.Diamond;
            }
        }

        protected bool Equals(Customer other)
        {
            return string.Equals(FirstName, other.FirstName) && string.Equals(MidleName, other.MidleName) && string.Equals(LastName, other.LastName) && Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((Customer)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return this.Id;
            }
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
        {
            return firstCustomer.Equals(secondCustomer);
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            return firstCustomer.Equals(secondCustomer);
        }

        public object Clone()
        {
            var cloning = new Customer(this.FirstName, this.MidleName, this.LastName,
            this.Id, this.PermanentAddress, this.Email, this.MobilePhone);

            cloning.Payments = new List<Payment>(this.Payments);
            cloning.CustomerType = this.CustomerType;

            return cloning;
        }

        public int CompareTo(Customer other)
        {
            string fullNameThisCustomer = this.ToString();
            string fullNameOtherCustomer = other.ToString();
            if (fullNameThisCustomer.CompareTo(fullNameOtherCustomer) == 0)
            {
                return this.Id.CompareTo(other.Id);
            }

            return fullNameThisCustomer.CompareTo(fullNameOtherCustomer);
        }
    }
}
