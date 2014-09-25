using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            try
            {
                string input = Console.ReadLine();
                double parced = Double.Parse(input);
                double result = Math.Sqrt(parced);
                Console.WriteLine("Square root: {0}", result);
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }

        }
    }
}
