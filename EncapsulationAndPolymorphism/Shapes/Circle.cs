namespace Shapes
{
    using System;

    class Circle : BasicShape
    {
        public Circle(double radius) : base(radius, 1)
        {
        }

        public override double CalculateArea()
        {
            var area = Math.PI * this.Width * this.Width;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = 2 * Math.PI * this.Width;
            return perimeter;
        }
    }
}
