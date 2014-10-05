namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected double Width
        {
            get { return this.width; }

            private set
            {
                Validation.CheckForValidSize("First parameter", value);
                this.width = value;
            }
        }

        protected double Height
        {
            get { return this.height; }

            private set
            {
                Validation.CheckForValidSize("Second parameter", value);
                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
