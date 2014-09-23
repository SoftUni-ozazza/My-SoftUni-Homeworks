/*
 Problem 9.	Play with Int, Double and String

Write a program that, depending on the user’s choice, 
 
        inputs an int, double or string variable. 

If the variable is int or double, the program increases it by one. 
If the variable is a string, the program appends "*" at the end. 

Print the result at the console. Use switch statement. 

 */

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        // Input options
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        
        int intInput = 1;
        double doubleInput = 1.0d;
        string stringInput = "*";

        string choice = Console.ReadLine();
        int input;
        bool isValid = Int32.TryParse(choice, out input); 

        if (isValid)
        {
            input = int.Parse(choice);
            switch (input)
            {
                case 1:
                    Console.Write("Please enter an integer: ");
                    intInput += int.Parse(Console.ReadLine());
                    Console.WriteLine(intInput);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    doubleInput += double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleInput);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    stringInput = Console.ReadLine() + stringInput;
                    Console.WriteLine(stringInput);
                    break;
                default:
                    Console.Write("Try again !");
                    break;
            }
        }
        else
        {
            Console.Write("Try again! "); ;
        }
    }
}