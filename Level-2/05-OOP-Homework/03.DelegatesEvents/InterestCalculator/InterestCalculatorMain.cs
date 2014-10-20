using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    //public delegate InterestCalculator InterestCalculationDelegate(string s);

    class InterestCalculatorMain
    {
        static void Main()
        {
            InterestCalculator pesho = new InterestCalculator(500, 6, 10);
            var result = pesho.GetCompoundInterest(500, 6, 10);
            Console.WriteLine("{0:F4}", result);
        }
    }

}
