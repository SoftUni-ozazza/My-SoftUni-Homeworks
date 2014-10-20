//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EnterNumbers
//{
//    class test
//    {
//        public static void Main()
//        {
//            const int NumberCount = 10;
//            List<int> allNumbers = new List<int>();
//            int start = 1;
//            int end = 100;
//            int number = -1;
//            for (int i = 0; i < NumberCount; i++)
//            {
//                if (i < 1)
//                {
//                    Console.WriteLine("Enter 10 positive numbers at separate line - ");
//                }

//                number = AskForStringAndReturnsValidatedNumber();
//                if (number != -1)
//                {
//                    if (ValidateNumberInRange(start, end, number))
//                    {
//                        allNumbers.Add(number);
//                    }

//                    int oldNumber = number;
//                }
//                else
//                {
//                    Console.WriteLine("Enter bigger than previous");
//                    if (i > -1)
//                    {
//                        i--;
//                    }
//                }
//            }
//        }

//        static int AskForStringAndReturnsValidatedNumber()
//        {
//            bool result;
//            string numString = Console.ReadLine();
//            do
//            {
//                Console.WriteLine("number: ");
//                result = IsNumber(numString);
//            } while (!result);

//            int number = int.Parse(numString);

//            return number;
//        }

//        static bool IsNumber(string numberString)
//        {
//            int number;
//            bool result = int.TryParse(numberString, out number);

//            return result;
//        }

//        static bool ValidateNumberInRange(int startRange, int endRange, int number)
//        {

//            bool result;
//            if (number < startRange && number > endRange)
//            {
//                result = false;
//            }
//            else
//            {
//                result = true;
//            }

//            return result;
//        }

//    }
//}
