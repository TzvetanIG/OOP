using System;

class LaptopShop
{
    static void Main()
    {
        Laptop laptop1 = new Laptop(
            model: "Lenovo Yoga 2 Pro",
            price: 650.00m
        );

        Console.WriteLine(laptop1.ToString()); 
        Console.WriteLine();

        Laptop laptop2 = new Laptop(
            model: "Lenovo Yoga 2 Pro",
            manufacturer: "Lenovo",
            processor: "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
            ram: 8,
            graphicsCard: "Intel HD Graphics 4400",
            hdd: "128GB SSD",
            screen: "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
            batteryDescription: "Li-Ion, 4-cells, 2550 mAh",
            batteryLifeInHours: 4.5,
            price: 2259.00m
        );

        Console.WriteLine(laptop2.ToString());
        Console.WriteLine();

        Laptop laptop3 = new Laptop(
            model: "Lenovo Yoga 2 Pro",
            ram: 8,
            hdd: "128GB SSD",
            screen: "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
            price: 2259.00m
        );

        Console.WriteLine(laptop3.ToString());
        Console.WriteLine();

    }
}

