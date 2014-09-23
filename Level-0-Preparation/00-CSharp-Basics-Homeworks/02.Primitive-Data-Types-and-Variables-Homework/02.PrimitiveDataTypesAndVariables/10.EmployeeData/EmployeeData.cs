/*
 Problem 10.	Employee Data
A marketing company wants to keep record of its employees. 
Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for 
a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.

 */

using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Gender: ");
        char gender = char.Parse(Console.ReadLine());

        Console.Write("Personal ID number: ");
        long personalID = long.Parse(Console.ReadLine());

        Console.Write("Unique employee number: ");
        int uniqueNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID number: {0}", personalID);
        Console.WriteLine("Unique employee number: {0}", uniqueNumber);
    }
}