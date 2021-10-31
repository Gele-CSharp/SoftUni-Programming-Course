using System;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length  
        {
            get => length;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }

                length = value;
            }
        }

        public double Width 
        {
            get => width;
            
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double Height 
        {
            get => height;
            
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public void GetSurfaceArea()
        {
            double surfaceArea = (2 * (length * width)) + (2 * (length * height)) + (2 * (width * height));
            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
        }

        public void GetLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (length * height) + 2 * (width * height);
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
        }

        public void GetVolume()
        {
            double volume = length * width * height;
            Console.WriteLine($"Volume - {volume:f2}");
        }
    }
}
