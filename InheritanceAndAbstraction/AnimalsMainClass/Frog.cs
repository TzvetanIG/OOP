using System;

class Frog : Animal
{
    public Frog(string name, int age, Genter genter)
        : base(name, age, genter)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("I squawk.");
    }
}

