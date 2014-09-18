using System;
using System.Collections.Generic;
using System.Linq;

class PcCatalog
{
    static void Main()
    {
        Componet boxPC = new Componet(name: "Кутия Shenha V6", price: 55.20m, details: "Размер: 475 x 185 x 465 cm");
        Componet motherboard = new Componet(name: "Дънна платка ASROCK FM2A88X Extreme6+", price: 188.40m);
        Componet hdd = new Componet(name: "Диск SEAGATE 2T, ES.3, SATA III", price: 330m, details: "Капацитет: 2 TB");
        Componet procesor = new Componet(name: "Процесор Intel Core I3-4340", price: 316.80m);
        Componet graficsCard = new Componet(name: "Видео карта PALIT GeForce GT 610", price: 80.40m, details: "Видео памет размер: 1 GB");
        Componet ram = new Componet(name: "Памет ADATA 2X4GB", price: 171.60m, details: "Описание: 2X4G DDR3");

        Componet discSSD = new Componet(name: "Диск A-DATA 128GB SSD", price: 127.20m, details: "Описание: Multi-Level Cell (MLC) NAND Flash Memory, 2.5 inch");
        Componet blower = new Componet(name: "Вентилатор COOLERMASTER Blade Master 80", price: 16.80m);
        Componet power = new Componet(name: "PSU FD 750W INTEGRA BLACK", price: 157.20m, details: "Описание: Multi-Level Cell (MLC) NAND Flash Memory, 2.5 inch");



        Computer computer1 = new Computer(
            name: "Frankenstein",
            boxPC: boxPC,
            motherboard: motherboard,
            hdd: hdd,
            procesor: procesor,
            graficsCard: graficsCard,
            ram: ram
        );

        Computer computer2 = new Computer("The Мachine", boxPC, motherboard, hdd, procesor, graficsCard, ram, discSSD, blower, power);

        Computer computer3 = new Computer("SbirotakModel", boxPC, motherboard, hdd, procesor, graficsCard, ram, discSSD);

        List<Computer> computers = new List<Computer>() { computer2, computer1, computer3, computer1 };


        computers = computers.OrderBy(computer => computer.Price).ToList();

        foreach (var computer in computers)
        {
            computer.writeToConsole();
            Console.WriteLine();
        }

    }
}
