using System;

namespace Methods
{
    class Method
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException("a", "Sides should be positive.");
            }

            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException("a", "Sides should be positive.");
            }

            if (c <= 0)
            {
                throw new ArgumentOutOfRangeException("c", "Sides should be positive.");
            }

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            return area;
        }

        static string Convert0To9ToDigitName(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    return "Enter valid number 0-9.";
            }
        }

        static int FindMaxInteger(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentNullException("numbers", "Can not interate over empthy array.");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                bool isNextNumberBigger = numbers[i] > numbers[0];
                if (isNextNumberBigger)
                {
                    numbers[0] = numbers[i];
                }
            }

            int biggestNumber = numbers[0];

            return biggestNumber;
        }

        static void PrintNumberInFormat(object number, string format)
        {
            bool isFloatingPoint = format == "f";
            if (isFloatingPoint)
            {
                Console.WriteLine("{0:f2}", number);
            }

            bool isModulo = format == "%";
            if (isModulo)
            {
                Console.WriteLine("{0:p0}", number);
            }

            bool isPrintToRight = format == "r";
            if (isPrintToRight)
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        static double CalcTwoPointsDistance(double xPoint1, double yPoint1, double xPoint2, double yPoint2)
        {
            double distance = Math.Sqrt((xPoint2 - xPoint1) * (xPoint2 - xPoint1) + (yPoint2 - yPoint1) * (yPoint2 - yPoint1));

            return distance;
        }

        static bool IsHorizontalLinePointToPoint(double yPointA, double yPointB)
        {
            bool isHorizontal = yPointA.Equals(yPointB);

            return isHorizontal;
        }

        private static bool IsVerticalLinePointToPoint(double xPoint1, double xPoint2)
        {
            bool isVertical = xPoint1.Equals(xPoint2);

            return isVertical;
        }


        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Convert0To9ToDigitName(5));

            Console.WriteLine(FindMaxInteger(5, -1, 3, 2, 14, 2, 3));

            PrintNumberInFormat(1.3, "f");
            PrintNumberInFormat(0.75, "%");
            PrintNumberInFormat(2.30, "r");

            double xPoint1 = 3;
            double yPoint1 = -1;
            double xPoint2 = 3;
            double yPoint2 = 2.5;

            Console.WriteLine(CalcTwoPointsDistance(xPoint1, yPoint1, xPoint2, yPoint2));
            Console.WriteLine("Horizontal? " + IsHorizontalLinePointToPoint(yPoint1, yPoint2));
            Console.WriteLine("Vertical? " + IsVerticalLinePointToPoint(xPoint1, xPoint2));

            Student peter =
                new Student()
            {
                FirstName = "Peter",
                LastName = "Ivanov"
            };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella =
                new Student()
                {
                    FirstName = "Stella",
                    LastName = "Markova"
                };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
