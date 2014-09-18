using System;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int? ram;
    private string graphicsCard;
    private string hdd;
    private decimal price;
    private string screen;

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.ValidationData(value, "model");
            this.model = value;
        }
    }
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            this.ValidationData(value, "manufacturer");
            this.manufacturer = value;
        }
    }
    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            this.ValidationData(value, "processor");
            this.processor = value;
        }
    }
    public int? Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            this.ValidationData(value, "ram");
            this.ram = value;
        }
    }
    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            this.ValidationData(value, "graphicsCard");
            this.graphicsCard = value;
        }
    }
    public string Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            this.ValidationData(value, "hdd");
            this.hdd = value;
        }
    }
    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            this.ValidationData(value, "screen");
            this.screen = value;
        }
    }
    public Battery Battery { get; set; }
    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            this.ValidationData(value, "price");
            this.price = value;
        }
    }


    public Laptop(string model, decimal price) :
        this(
            model: model,
            manufacturer: null,
            processor: null,
            ram: null,
            graphicsCard: null,
            hdd: null,
            screen: null,
            batteryDescription: null,
            batteryLifeInHours: 0,
            price: price
        )
    {
    }

    public Laptop(string model, string manufacturer, string processor, int? ram, string graphicsCard, string hdd, string screen, string batteryDescription, double batteryLifeInHours, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        if (!(String.IsNullOrEmpty(batteryDescription) && batteryLifeInHours <= 0))
        {
            this.Battery = new Battery(description: batteryDescription, lifeInHours: batteryLifeInHours);
        }
        this.Price = price;
    }

    public Laptop(string model, int? ram, string hdd, string screen, decimal price) :
        this(
            model: model,
            manufacturer: null,
            processor: null,
            ram: ram,
            graphicsCard: null,
            hdd: hdd,
            screen: screen,
            batteryDescription: null,
            batteryLifeInHours: 0,
            price: price
        )
    {
    }

    public override string ToString()
    {
        return String.Format("Model: {0}\n{1}{2}{3}{4}{5}{6}{7}Price: {8}",
            this.Model,
            this.FieldToString("Manufacturer", this.Manufacturer),
            this.FieldToString("Processor", this.Processor),
            this.FieldToString("RAM", this.Ram),
            this.FieldToString("Graphics Card", this.GraphicsCard),
            this.FieldToString("HDD", this.Hdd),
            this.FieldToString("Screen", this.Screen),
            this.FieldToString("Battery", this.Battery),
            this.Price
            );
    }

    private string FieldToString(string field, object value)
    {
        if (value == null)
        {
            return null;
        }

        return field + ": " + value.ToString() + "\n";
    }


    private void ValidationData(object data, string argument)
    {
        if (data is string)
        {
            if ((string)data == "")
            {
                throw new ArgumentException("The argument must not to be empty string.", argument);
            }
        }
        else if (data is int)
        {
            if ((int)data <= 0)
            {
                throw new ArgumentException("The argument must not to be negative or zero.", argument);
            }
        }
        else if (data is decimal)
        {
            if ((decimal)data <= 0)
            {
                throw new ArgumentException("The argument must not to be negative or zero.", argument);
            }
        }
    }

}

