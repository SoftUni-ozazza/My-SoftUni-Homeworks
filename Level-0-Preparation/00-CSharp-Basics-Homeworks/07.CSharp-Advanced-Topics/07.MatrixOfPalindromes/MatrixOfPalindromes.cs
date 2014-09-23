/*
 Problem 7.	Matrix of Palindromes

Write a program to generate the following matrix of palindromes 
of 3 letters with r rows and c columns

 */

using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("row = ");
        int numberForRows = int.Parse(Console.ReadLine());
        Console.Write("col = ");
        int numberForCols = int.Parse(Console.ReadLine());
        GeneratePalindromeMatrix(numberForRows, numberForCols);
    }

    private static void GeneratePalindromeMatrix(int numberForRows, int numberForCols)
    {

        char abc = 'a';
        string[,] abcArray = new string[numberForRows, numberForCols];

        for (int row = 0; row < numberForRows; row++)
        {
            for (int col = 0; col < numberForCols; col++)
            {
                abcArray[row, col] = "" + (char)(abc + row) + (char)(abc + col + row) + (char)(abc + row);
            }
        }

        for (int row = 0; row < numberForRows; row++)
        {
            for (int col = 0; col < numberForCols; col++)
            {
                Console.Write(abcArray[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}