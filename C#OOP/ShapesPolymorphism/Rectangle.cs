using System;

namespace ShapesPolymorphism
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width 
        {
            get => width;
            
            protected set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The Width can not be zero or negative");
                }

                width = value;
            }
        }

        public double Height
        {
            get => height;

            protected set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The Height can not be zero or negative");
                }

                height = value;
            }
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePerimeter()
        {
            return height + height + width + width;
        }

        public override string Draw()
        {
            return "I am Rectangle".ToString();
        }
    }
}
