namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;

    public class EnterNumbers
    {
        public static void Main()
        {
            const int NumberCount = 10;
            List<int> allNumbers = new List<int>();
            int start = 1;
            int end = 100;
            int number = -1;
            int oldNumber = -1;
            for (int i = 0; i < NumberCount; i++)
            {
                if (i < 1)
                {
                    Console.Write("Enter 10 positive numbers at separate line - ");
                }

                number = AskForStringAndReturnsValidatedNumber();
                if (number != -1)
                {
                    if (ValidateNumberInRange(start, end, number) && number > oldNumber)
                    {
                        allNumbers.Add(number);
                        oldNumber = number;
                    }
                    else
                    {
                        if (number <= oldNumber)
                        {
                            Console.Write("Enter bigger than previous ");
                        }
                        if (!ValidateNumberInRange(start, end, number))
                        {
                            Console.Write("Enter in range {0} to {1} ", start, end);
                        }
                        if (i > -1)
                        {
                            i--;
                        }
                    }
                }
            }

            foreach (var num in allNumbers)
            {
                Console.WriteLine(num);
            }
        }

        static int AskForStringAndReturnsValidatedNumber()
        {
            bool result;
            string numString = String.Empty;
            do
            {
                Console.WriteLine("number: ");
                numString = Console.ReadLine();
                result = IsNumber(numString);
            } while (!result);

            int number = int.Parse(numString);

            return number;
        }

        static bool IsNumber(string numberString)
        {
            int number;
            bool result = int.TryParse(numberString, out number);

            return result;
        }

        static bool ValidateNumberInRange(int startRange, int endRange, int number)
        {

            bool result;
            if (number < startRange && number > endRange)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

    }
}




//namespace EnterNumbers
//{
//    using System;
//    using System.Collections.Generic;

//    class EnterNumbers
//    {
//        //static void Main()
//        {
//            const int NumberCount = 10;

//            int number;
//            int oldNumber = 0;
//            List<int> allNumbers = new List<int>();
//            //for (int i = 0; i < NumberCount; i++)
//            {

//                if (i < 1)
//                {
//                    Console.WriteLine("Enter 10 numbers each at separate line. ");
//                }
//                else
//                {
//                    Console.Write("Enter number bigger than previous n>{0} ", oldNumber);
//                }

//                int start = 1;
//                int end = 100;
//                number = ReadNumber(start, end);
//                if (number > oldNumber)
//                {
//                    allNumbers.Add(number);
//                }
//                else
//                {
//                    while (number <= oldNumber)
//                    {
//                        Console.Write("Enter bigger ");
//                        number = ReadNumber(start, end);
//                        if (number > oldNumber)
//                        {
//                            allNumbers.Add(number);
//                            break;
//                        }
//                    }
//                }
//                oldNumber = number;
//            }

//            foreach (int n in allNumbers)
//            {
//                Console.WriteLine(n);
//            }
//        }

//        static int ReadNumber(int start, int end)
//        {
//            Console.WriteLine("number: ");
//            string numberStr = Console.ReadLine();

//            int num = 0;
//            if (IsNumber(numberStr))
//            {
//                num = int.Parse(numberStr);

//                while (num < start && num > end)
//                {
//                    Console.WriteLine("Number not in range! Enter: ");
//                    {
//                        num = int.Parse(Console.ReadLine());
//                        if (num > start && num < end)
//                        {
//                            break;
//                        }
//                    }
//                }

//                return num;
//            }
//            else
//            {
//                while (!IsNumber(numberStr))
//                {
//                    Console.Write("Try again: ");

//                    string numberStr = Console.ReadLine();
//                    num = int.Parse(numberStr);
//                    if (IsNumber(numberStr))
//                    {
//                        break;
//                    }
//                }
//            }

//            return num;
//        }

//        static bool IsNumber(string numberStr)
//        {
//            int number;
//            bool result = int.TryParse(numberStr, out number);
//            return result;
//        }
//    }
//}
