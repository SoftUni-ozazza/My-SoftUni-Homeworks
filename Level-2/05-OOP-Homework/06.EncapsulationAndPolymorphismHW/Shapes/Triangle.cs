using System;

namespace Shapes
{
    public class Triangle : BasicShape, IShape
    {
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
            : base(sideA, sideB)
        {
            this.SideC = sideC;
        }

        public double SideC
        {
            get
            {
                return this.sideC;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("sideC", "The value of sideC must be positive number.");
                }

                SideC = value;
            }
        }

        public override double CalculateArea()
        {
            double p = CalculatePerimeter()/2;
            double areaTriangle = Math.Sqrt(p*(p - Height)*(p - Width)*(p - SideC));

            return areaTriangle;
        }

        public override double CalculatePerimeter()
        {
            double perimeterTriangle = Width + Height + SideC;

            return perimeterTriangle;
        }
    }
}