/*
 Problem 19.	** Spiral Matrix

Write a program that reads from the console 
a positive integer number n (1 ≤ n ≤ 20) 
and prints a matrix holding the numbers from 1 to n*n 
in the form of square spiral like in the examples below. 
 * Examples:
n	matrix		n	matrix		n	matrix
2	1 2
    4 3		    3	1 2 3
                    8 9 4
                    7 6 5		4	1  2  3  4
                                    12 13 14 5
                                    11 16 15 6
                                    10 9  8  7

 */

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[,] matrix = new int[n, n];

        int row = 0;
        int rowMax = n - 1;
        int rowMin = 0;

        int col = 0;
        int colMax = n - 1;
        int colMin = 0;

        //int i = 1;
        //int j = 0;
        //int cornerFormula = (i * n) - (j);
        int countToNbyN = 1;

        int steps = (2 * n) - 1;
        int stepsCounter = 1;

        while (steps > 0)
        {
            if (row == rowMin && col == colMin)                     // col ++;  step 1
            {                                                       //          step 5    
                if (stepsCounter % 2 > 0 && stepsCounter != 1)      //          step 9
                {                                                   //          step 13
                    colMin += 1;
                }
                for (col = colMin; ; col++)
                {
                    matrix[row, col] = countToNbyN;
                    countToNbyN++;
                    if (col == colMax)
                    {
                        break;
                    }
                }
                steps -= 1;
                stepsCounter++;
                if (countToNbyN > n * n)
                {
                    break;
                }
            }

            if (row == rowMin && col == colMax)                 // row ++;      step 2
            {                                                   //              step 6
                if (stepsCounter % 2 < 1)                       //              step 10
                {                                               //              step 14
                    rowMin += 1;
                }
                for (row = rowMin; ; row++)
                {
                    matrix[row, col] = countToNbyN;
                    countToNbyN++;
                    if (row == rowMax)
                    {
                        break;
                    }
                }
                steps -= 1;
                stepsCounter++;
                if (countToNbyN > n * n)
                {
                    break;
                }
            }

            if (row == rowMax && col == colMax)                 // col --;      step 3
            {                                                   //              step 7
                if (stepsCounter % 2 > 0 && stepsCounter != 1)  //              step 11
                {                                               //              step 15
                    colMax -= 1;
                }
                for (col = colMax; ; col--)
                {
                    matrix[row, col] = countToNbyN;
                    countToNbyN++;
                    if (col == colMin)
                    {
                        break;
                    }
                }
                steps -= 1;
                stepsCounter++;
                if (countToNbyN > n * n)
                {
                    break;
                }
            }

            if (row == rowMax && col == colMin)                  // row --; step 4
            {                                                   //          step 8
                if (stepsCounter % 2 < 1)                       //          step 12
                {                                               //          step 16
                    rowMax -= 1;
                }
                for (row = rowMax; ; row--)
                {
                    matrix[row, col] = countToNbyN;
                    countToNbyN++;
                    if (row == rowMin)
                    {
                        break;
                    }
                }
                steps -= 1;
                stepsCounter++;
                if (countToNbyN > n * n)
                {
                    break;
                }
            }
        }
        if (countToNbyN > n * n)
        {
            //printing
            for (int s = 0; s < matrix.GetLength(0); s++)
            {
                for (int m = 0; m < matrix.GetLength(1); m++)
                {
                    Console.Write("{0,4}", matrix[s, m]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return;
        }
    }
}