using System;

namespace ShapesPolymorphism
{
    class Circle : Shape
    {
        private double radious;

        public Circle(double radious)
        {
            Radious = radious;
        }

        public double Radious
        {
            get => radious; 
            
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The Radious can not be zero or negative");
                }

                radious = value;
            }
        }


        public override double CalculateArea()
        {
            return Math.PI * radious * radious;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radious;
        }

        public override string Draw()
        {
            return $"I am Circle".ToString();
        }
    }
}
