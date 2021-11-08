using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radious;

        public Circle(int radious)
        {
            this.radious = radious;
        }

        public void Draw()
        {
            double rIn = this.radious - 0.4;
            double rOut = this.radious + 0.4;

            for (double y = this.radious; y >= -this.radious; y--)
            {
                for (double x = -this.radious; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
