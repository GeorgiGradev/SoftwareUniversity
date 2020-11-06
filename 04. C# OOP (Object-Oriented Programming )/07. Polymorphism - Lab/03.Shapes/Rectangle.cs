using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return this.height * this.width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (this.height + this.width);
        }
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
