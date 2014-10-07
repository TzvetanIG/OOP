using System;

namespace Customer
{
    class TestCustomer
    {
        static void Main()
        {
            var pesho = new Customer("Petar", "Ivanov", "Mitrev", 123456789);
            var pesho2 = new Customer("Petar", "Ivanov", "Mitrev", 123456788);
            var gosho = new Customer("Gosho", "Ivanov", "Shopov", 100000001);

            Payment[] payments =
            {
                new Payment("book", 25.5m),
                new Payment("phone", 250.89m),
                new Payment("tablet", 500),
                new Payment("phone", 250.89m),
                new Payment("tablet", 500)
            };

            foreach (var payment in payments)
            {
                pesho.AddPayment(payment);
                gosho.AddPayment(payment);
            }

            var petarCloning = (Customer)pesho.Clone();

            Console.WriteLine(pesho == gosho);
            Console.WriteLine(pesho == pesho);
            Console.WriteLine(pesho == petarCloning);

            Console.WriteLine(pesho.CompareTo(gosho));
            Console.WriteLine(pesho2.CompareTo(pesho));
            Console.WriteLine(pesho.CompareTo(petarCloning));
        }
    }
}
