/*
 Problem 5.	Sorting Numbers
Write a program that reads a number n and a sequence of n integers, 
sorts them and prints them. 

 */

using System;
using System.Collections.Generic;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers ");
        int numbers = int.Parse(Console.ReadLine());

        List<int> sequense = AddNumbersToList(numbers);
        sequense.Sort();
        PrintListRowByRow(sequense);
    }

    private static List<int> AddNumbersToList(int numbers)
    {
        List<int> sequense = new List<int>();
        for (int cell = 0; cell < numbers; cell++)
        {
            int num = int.Parse(Console.ReadLine());
            sequense.Add(num);
        }
        return sequense;
    }

    private static void PrintListRowByRow(List<int> sequense)
    {
        Console.WriteLine("Sorted sequence: ");
        foreach (int item in sequense)
        {
            Console.WriteLine("{0}", item);
        }
    }
}