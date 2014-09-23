/*
 Problem 12.	* Zero Subset

We are given 5 integer numbers. 
Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem. 

Hint: you may check for zero each of the 32 subsets with 32 if statements.
 */

using System;

class ZeroSubset
{
    static void Main()
    {
        int numbers = 5;
        int[] nArray = new int[numbers];
        int sum = 0;

        // add the numbers
        for (int i = 0; i < numbers; i++)
        {
            nArray[i] = int.Parse(Console.ReadLine());
        }

        // the possible combinations are 2^numbers (2^5)
        int combinations = 1;
        for (int i = 1; i <= numbers; i++)
        {
            combinations *= 2;
        }
        combinations -= 1;

        // look bit by bit each number in possible combinations
        int counter = 0;
        for (int i = 1; i <= combinations; i++)
        {
            int plusRemover = 0;
            int currentSum = 0;
            string[] currentNumbers = new string[numbers];
            for (int j = 0; j < numbers; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currentSum += nArray[j];
                    currentNumbers[j] = Convert.ToString(nArray[j]);
                    plusRemover++;
                }
            }
            int plusAdd = 0;
            if (currentSum == sum)
            {
                counter++;
                for (int m = 0; m < currentNumbers.Length; m++)
                {
                    if (currentNumbers[m] != null)
                    {
                        // remove the last plus sign
                        plusAdd++;
                        if (plusAdd == plusRemover)
                        {
                            Console.Write(currentNumbers[m] + " ");
                        }
                        else
                        {
                            Console.Write(currentNumbers[m] + " + ");
                        }
                    }
                }
                Console.WriteLine("= 0");
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("no such a subset");
        }
    }
}