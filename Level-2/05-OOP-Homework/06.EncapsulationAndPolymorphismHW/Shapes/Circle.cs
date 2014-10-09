using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        public double CalculateArea()
        {
            double areaCircle = Math.PI * this.Radius * this.Radius;
            return areaCircle;
        }

        public double CalculatePerimeter()
        {
            double perimeterCircle = 2 * this.Radius * this.Radius;
            return perimeterCircle;
        }
    }
}
