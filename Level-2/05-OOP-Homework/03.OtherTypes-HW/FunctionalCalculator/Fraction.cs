using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCalculator
{

    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set { checked { this.numerator = value; } }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Value must be positive or negative but not zero!");
                }
                checked { this.denominator = value; }
            }
        }

        public static Fraction operator +(Fraction numberFirst, Fraction numberSecond)
        {
            checked
            {
                long numerator = (numberFirst.numerator * numberSecond.denominator) + (numberFirst.denominator * numberSecond.numerator);
                long denominator = numberFirst.denominator * numberSecond.denominator;
                return new Fraction(numerator, denominator);
            }
        }

        public static Fraction operator -(Fraction numberFirst, Fraction numberSecond)
        {
            checked
            {
                long numerator = (numberFirst.numerator * numberSecond.denominator) - (numberFirst.denominator * numberSecond.numerator);
                long denominator = numberFirst.denominator * numberSecond.denominator;
                return new Fraction(numerator, denominator);
            }
        }

        // output
        public override string ToString()
        {
            decimal result = (decimal)this.numerator / this.denominator;
            return string.Format("{0}", result);
        }
    }
}
