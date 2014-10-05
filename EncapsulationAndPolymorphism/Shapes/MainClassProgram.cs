using System;
using Shapes;

class MainClassProgram
{
    static void Main()
    {
        var shapes = new IShape[]
        {
            new Triangle(3, 4, 5), 
            new Triangle(1, 2.5, 3),
            new Rectangle(2.5, 4), 
            new Circle(1)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.GetType().Name + ": ");
            Console.WriteLine(" Area: {0:f2}", shape.CalculateArea());
            Console.WriteLine(" Perimeter: {0:f2}", shape.CalculatePerimeter());
            Console.WriteLine();
        }
    }
}
