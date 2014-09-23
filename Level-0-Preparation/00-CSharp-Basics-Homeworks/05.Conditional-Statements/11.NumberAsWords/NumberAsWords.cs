/*
 Problem 11.	* Number as Words

Write a program that converts 
a number in the range [0…999] to words,  
corresponding to the English pronunciation. 

 */

using System;

class NumberAsWords
{
    static void Main()
    {
        // n will be used as a string and as an integer
        string nString = Console.ReadLine();
        int n;
        bool inputIsNumber = int.TryParse(nString, out n);

        // if input is not a number the program will finished here
        if (inputIsNumber)
        {
            // the length of string will measure the length of nArray (the storage of the words of input)
            int length = nString.Length;

            string[] nArray = new string[length];

            // each digit in input will corresponding to next two arrays
            string[] array0to19 = { "zero", "one", "two", "three", "four",
                                    "five", "six", "seven", "eight", "nine",
                                    "ten", "eleven", "twelve", "thirteen", "fourteen",
                                    "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            string[] arrayOf10s = { "", "ten", "twenty", "thirty", "forty", 
                                   "fifty", "sixty", "seventy", "eighty", "ninety" };
            
            // the n as integer will be used in expression to get each digit in input
            n = int.Parse(nString);

            // (n / counter) % p
            int p = 10;
            int counter = 1;
            int i = nArray.Length - 1;

            switch (length)
	        {
                // if it's three digit number
                case 3:

                    // last digit if it's 0 --> (n / 1) % 10
                    if ((n / counter) % p == 0) 
                    {
                        nArray[i] = "";
                        counter *= p;
                        i--;

                        // second digit if it's 0 --> (n / 10) % 10 --> numbers 100, 200, 400.. 900
                        if ((n / counter) % p == 0)
                        {
                            nArray[i] = "";
                            counter *= p;
                            i--;

                            // first digit --> (n / 100) % 100
                            nArray[i] = array0to19[(n / counter) % p] + " hundred";
                            Console.WriteLine(nArray[i]);
                            break;
                        }

                        // just last digit is zero --> 120, 450, 710...
                        else
                        {
                            nArray[i] = "and " + arrayOf10s[(n / counter) % p];
                            counter *= p;
                            i--;
                            nArray[i] = array0to19[(n / counter) % p] + " hundred";

                            // printing
                            for (int index = 0; index < nArray.Length; index++)
                            {
                                Console.Write(nArray[index] + " ");
                            }
                            Console.WriteLine();
                            break;
                        }
                    }

                    // last digit isn't 0
                    else if ((n / counter) % p != 0)
                    {
                        int nIndex = (n / counter) % p;
                        counter *= p;
                        i--;

                        // second digit --> if it's 1
                        if ((n / counter) % p == 1)
                        {
                            // last digit
                            nArray[i + 1] = "";

                            // second digit takes value from 11 to 19 --> numbers 111, 316, 719.. (x11 to x19)
                            nArray[i] = "and " + array0to19[10 + nIndex];
                            counter *= p;
                            i--;

                            // first digit
                            nArray[i] = array0to19[(n / counter) % p] + " hundred";

                            // printing
                            for (int index = 0; index < nArray.Length; index++)
                            {
                                Console.Write(nArray[index] + " ");
                            }
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            // last digit
                            nArray[i + 1] = array0to19[nIndex];

                            // second digit --> remove an space while printing
                            if ((n / counter) % p != 0)
                            {
                                nArray[i] = "and " + arrayOf10s[(n / counter) % p];
                            }
                            else
                            {
                                nArray[i] = "and" + arrayOf10s[(n / counter) % p];
                            }
                            counter *= p;
                            i--;

                            // first digit --> (n / 100) % 10
                            nArray[i] = array0to19[(n / counter) % p] + " hundred";

                            // printing
                            for (int index = 0; index < nArray.Length; index++)
                            {
                                Console.Write(nArray[index] + " ");
                            }
                            Console.WriteLine();
                        } 
                    }
                    break;

                // if it's two digit number
                case 2:

                    // last digit 
                    if ((n / counter) % p == 0)
                    {
                        nArray[i] = "";
                        counter *= p;
                        i--;

                        // first digit
                        nArray[i] = arrayOf10s[(n / counter) % p];
                        Console.WriteLine(nArray[i]);
                        break;
                    }
                    else
                    {
                        nArray[i] = array0to19[(n / counter) % p];
                        counter *= p;
                        i--;

                        // first digit
                        if ((n / counter) % p == 1)
                        {
                            string result = array0to19[n];
                            Console.WriteLine(result);
                            break;
                        }
                        else if ((n / counter) % p == 0)
                        {
                            Console.WriteLine("invalid number");
                            break;
                        }
                        else
                        {
                            nArray[i] = arrayOf10s[(n / counter) % p];
                        }
                    }

                    // printing
                    for (int index = 0; index < nArray.Length; index++)
                    {
                        Console.Write(nArray[index] + " ");
                    }
                    Console.WriteLine();
                    break;

                // if it's one digit number
                case 1:
                    nArray[i] = array0to19[(n / counter) % p];
                    Console.WriteLine(nArray[i]);
                    break;

		        default:
                    if (length > 3 || length < 1)
                    {
                        Console.WriteLine("Try [1...999]");
                    }
                    break;
            }
	    }
        else
        {
            Console.WriteLine("it's not a number");
        }
    }
}