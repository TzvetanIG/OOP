namespace Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            var area = this.Width * this.Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = 2 * this.Width + 2 * this.Height;
            return perimeter;
        }
    }
}
