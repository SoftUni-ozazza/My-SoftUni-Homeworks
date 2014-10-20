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

                this.sideC = value;
            }
        }

        public override double CalculateArea()
        {
            double p = this.Width + this.Height + this.SideC / 2;
            double areaTriangle = Math.Sqrt(p*(p - this.Height)*(p - this.Width)*(p - this.SideC));

            return areaTriangle;
        }

        public override double CalculatePerimeter()
        {
            double perimeterTriangle = this.Width + this.Height + this.SideC;

            return perimeterTriangle;
        }
    }
}