using System;

class Componet
{
    private string name;
    private decimal price;
    private string details;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            Validation.CheckForNullOrEmptyString(value, "name");
            this.name = value;
        }
    }

    public decimal Price
    {
        get 
        {
            return this.price; 
        }
        set 
        {
            Validation.CheckForNegativeOrZero(value, "price");
            this.price = value; 
        }
    }

    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            Validation.CheckForEmptyString(value, "name");
            this.details = value;
        }
    }

    public Componet(string name, decimal price, string details = null)
    {
        this.Name = name;
        this.Price = price;
        this.details = details;
    }
}

