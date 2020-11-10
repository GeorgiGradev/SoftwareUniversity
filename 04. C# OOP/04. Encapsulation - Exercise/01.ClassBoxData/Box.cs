using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    
    public class Box
    {
        private const string errorMessage = "{0} cannot be zero or negative.";
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
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(errorMessage, "Length"));
                }
                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(errorMessage, "Width"));
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(errorMessage, "Height"));
                }
                this.height = value;
            }
        }



        public string SurfaceArea()
        {
            double surfaceArea = 2 * this.length * this.width
                + 2 * this.length * this.height
                + 2 * this.width * this.height;
            return $"Surface Area - {surfaceArea:f2}";
        }

        public string LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * this.length * this.height + 2 * this.width * this.height;
            return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
        }

        public string Volume()
        {
            double volume = this.length * this.width * this.height; 
            return $"Volume - {volume:f2}";
        }
    }
}


//Volume = lwh
//Lateral Surface Area = 2lh + 2wh
//Surface Area = 2lw + 2lh + 2wh