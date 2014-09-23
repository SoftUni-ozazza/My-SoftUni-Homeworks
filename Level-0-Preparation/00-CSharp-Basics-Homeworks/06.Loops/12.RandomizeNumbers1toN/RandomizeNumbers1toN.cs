/*
 Problem 12.	* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n 
in random order. 

 Examples:
    n	    randomized numbers 1…n
    3	    2 1 3
    10	    3 4 8 2 6 7 9 1 10 5 
 
Note that the above output is just an example. Due to randomness, your 
program most probably will produce different results. 
 * You might need to use arrays.

 */

using System;
using System.Linq;

class RandomizeNumbers1toN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] oneToN = new int[n];
        int min = 1;
        int max = n;
        int check = 0;

        // random generator
        Random random = new Random();

        // assign values in random order        
        for (int i = 0; i < oneToN.Length;)
        {
            check = random.Next(min, max + 1);
            while (!(oneToN.Contains(check)))
            {
                oneToN[i] = check;
                i++;
            }
        }

        // print
        for (int i = 0; i < oneToN.Length; i++)
        {
            Console.Write("{0} ", oneToN[i]);
        }
        Console.WriteLine();
    }
}