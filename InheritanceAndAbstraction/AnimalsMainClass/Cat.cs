using System;

public class Cat : Animal
{
    public Cat(string name, int age, Genter genter)
        : base(name, age, genter)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("I meow.");
    }
}

