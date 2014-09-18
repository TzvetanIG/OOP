using System;
using System.Collections.Generic;

class Computer
{
    private string name;
    private List<Componet> componets = new List<Componet>();
    private decimal price;


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
    }

    public Computer(string name, Componet boxPC, Componet motherboard, Componet hdd, Componet procesor, Componet graficsCard, Componet ram)
    {
        this.Name = name;
        this.componets.Add(boxPC);
        this.componets.Add(motherboard);
        this.componets.Add(hdd);
        this.componets.Add(procesor);
        this.componets.Add(graficsCard);
        this.componets.Add(ram);
        foreach (Componet componet in this.componets)
        {
            this.price += componet.Price;
        }
    }

    public Computer(string name, Componet boxPC, Componet motherboard, Componet hdd, Componet procesor, Componet graficsCard, Componet ram, params Componet[] componets) :
        this(name, boxPC, motherboard, hdd, procesor, graficsCard, ram)
    {
        this.componets.AddRange(componets);
        foreach (Componet componet in componets)
        {
            this.price += componet.Price;
        }
    }

    public void writeToConsole()
    {
        Console.WriteLine("{0} - {1:f2} лв.", this.Name, this.price);
        foreach (var componet in this.componets)
        {
            Console.WriteLine(" - {0} - {1:f2} лв.", componet.Name, componet.Price);
        }
    }
}

