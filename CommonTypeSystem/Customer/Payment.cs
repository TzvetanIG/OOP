namespace Customer
{
    class Payment
    {
        public Payment(string productName, decimal price)
        {
            this.Price = price;
            this.ProductName = productName;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
