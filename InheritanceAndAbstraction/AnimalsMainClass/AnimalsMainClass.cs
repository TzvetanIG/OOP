using System;
using System.Globalization;
using System.Linq;

class AnimalsMainClass
{
    static void Main()
    {
        var animals = new Animal[]
        {
            new Dog("Spot", 2, Genter.Male), 
            new Cat("Pisana", 1, Genter.Femail), 
            new Frog("Jabcho", 1, Genter.Male), 
            new Kitten("Kity", 5), 
            new Tomcat("Tom", 3)
        };

        animals.ToList().ForEach(Console.WriteLine);

        Console.WriteLine();

        Console.WriteLine("The average age of animals is {0}.", animals.Average(a => a.Age));
    }
}

