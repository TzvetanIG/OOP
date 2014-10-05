namespace Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        private double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
            : base(firstSide, secondSide)
        {
            Validation.CheckForValidTriangle(firstSide, secondSide, thirdSide);
            this.ThirdSide = thirdSide;
        }

        private double ThirdSide
        {
            get { return this.thirdSide; }

            set
            {
                Validation.CheckForValidSize("Third parameter", value);
                this.thirdSide = value;
            }
        }

        public override double CalculateArea()
        {
            var p = (this.Height + this.Width + this.thirdSide) / 2;
            var area = Math.Sqrt(p * (p - this.Height) * (p - this.Width) * (p - this.ThirdSide));
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = this.Height + this.Width + this.thirdSide;
            return perimeter;
        }
    }
}
