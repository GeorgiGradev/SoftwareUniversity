using System;

namespace Shapes
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectange = new Rectangle(10, 4);
            Shape circle = new Circle(3);

            Console.WriteLine(rectange.CalculateArea());
            Console.WriteLine(rectange.CalculatePerimeter());
            Console.WriteLine(rectange.Draw());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectange.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
        }
    }
}
