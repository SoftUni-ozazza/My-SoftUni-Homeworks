/*
Problem 3.	Primes in Given Range
 
Write a method that calculates all prime numbers in given range and 
returns them as list of integers:

static List<int> FindPrimesInRange(startNum, endNum)
{
    …
}
Write a method to print a list of integers. Write a program that 
enters two integer numbers (each at a separate line) and 
prints all primes in their range, separated by a comma.

 * 
 * Note: От математиката знаем, че ако едно число не е просто, 
 * то съществува поне един делител в интервала 
 * [2 … корен квадратен от даденото число].
 * За всяко число търсим дали има делител в този интервал. 
 * Ако срещнем делител, то числото не е просто и можем да продължим със следващото.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimesInRangeMethod
{
    static void Main()
    {
        Console.Write("range start from: ");
        int startNum = int.Parse(Console.ReadLine());
        Console.Write("range ends to: ");
        int endNum = int.Parse(Console.ReadLine());

        List<int> range = FindPrimes(startNum, endNum);
        PrintList(range);
    }

    private static void PrintList(List<int> range)
    {
        int counter = 0;
        foreach (int item in range)
        {
            counter++;
            if (range.Count < counter)
            {
                Console.Write("{0}, ", item);
            }
            else
            {
                Console.Write("{0}, ", item);
            }
        }
    }

    private static List<int> FindPrimes(int startNum, int endNum)
    {
        List<int> range = new List<int>();
        if (startNum < endNum)
        {
            for (int p = startNum; p <= endNum; p++)
            {
                bool isPrime = true;
                double pSqrt = Math.Sqrt(p);
                for (int div = 2; div <= pSqrt; div++)
                {
                    if (p % div == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    range.Add(p);
                }
            }
        }
        return range;
    }
}
