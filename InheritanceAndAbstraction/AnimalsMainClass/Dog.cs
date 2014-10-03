using System;

public class Dog : Animal
{
    public Dog(string name, int age, Genter genter)
        : base(name, age, genter)
    {

    }

    public override void ProduceSound()
    {
        Console.WriteLine("I bark.");
    }
}

