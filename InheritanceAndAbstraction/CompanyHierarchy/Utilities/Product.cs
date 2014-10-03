namespace CompanyHierarchy.Utilities
{
    using System;

    public class Product
    {
        public Product(string name, DateTime date, decimal price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} BGN", this.Name, this.Price);
        }
    }
}
