namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        private double width;
        private double height;

        public Figure()
        {
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("width",
                        "Width value should be positive and not zero.");
                }

                this.width = value;
            }
        }

        public virtual double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("height",
                        "Height value should be positive and not zero.");
                }

                this.height = value;
            }
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();


    }
}
