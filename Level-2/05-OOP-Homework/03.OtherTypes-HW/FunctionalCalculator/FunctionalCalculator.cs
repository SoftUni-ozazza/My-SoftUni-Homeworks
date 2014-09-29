using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCalculator
{
    class FunctionalCalculator
    {
        static void Main()
        {
            Fraction calc1 = new Fraction(22, 7);
            Fraction calc2 = new Fraction(40, 4);
            Fraction result = calc1 + calc2;

            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}
