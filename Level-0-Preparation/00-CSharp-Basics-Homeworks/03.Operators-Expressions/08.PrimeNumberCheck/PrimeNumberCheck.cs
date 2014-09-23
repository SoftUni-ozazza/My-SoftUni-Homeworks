/*
 Problem 8.	Prime Number Check

Write an expression that checks if given positive integer number 
        n (n ≤ 100) is prime 
(i.e. it is divisible without remainder only to itself and 1). 

 */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = ((number == 2) || (number == 3) ||
                        (number == 5) || (number == 7)) ||
                        ((number % 2 > 0) && (number % 3 > 0) && 
                        (number % 5 > 0) && (number % 7 > 0));

        if ((number >= 0) && (number <= 100))
        {
            if ((number == 0) || number == 1)
            {
                isPrime = false;
            }
            Console.WriteLine("Is it a prime: " + isPrime);            
        }
        else
        {
            Console.WriteLine("The number is larger than 100!");
        }
    }
}