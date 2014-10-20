namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class ShapesMain
    {
        static void Main()
        {
            var shapes = new List<IShape>()
            {
                new Circle(3), 
                new Circle(5), 
                new Triangle(2.4, 3.5, 4),  
                new Triangle(12, 3.91, 6.04), 
                new Rectangle(3, 2.9), 
                new Rectangle(8, 4.3)
            };

            PrintCollection(shapes);

        }

        public static void PrintCollection(IEnumerable<IShape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine("Type: {0} -> Area: {1:F2} -> Perimeter: {2:F2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
