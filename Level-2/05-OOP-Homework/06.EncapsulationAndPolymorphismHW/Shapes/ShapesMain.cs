namespace Shapes
{
    using System;

    public class ShapesMain
    {
        static void Main()
        {
            var rec = new Triangle(1, 2, 3);

            Console.WriteLine(rec.Width);
            Console.WriteLine(rec.Height);
            Console.WriteLine(rec.SideC);
            //Console.WriteLine(rec.CalculateArea());
            //Console.WriteLine(rec.CalculatePerimeter());
        }
    }
}
