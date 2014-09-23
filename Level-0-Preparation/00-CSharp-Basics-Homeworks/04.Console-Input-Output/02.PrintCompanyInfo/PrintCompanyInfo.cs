/*
 Problem 2.	Print Company Information

A company has name, address, phone number, fax number, web site and manager. 
The manager has first name, last name, age and a phone number. 

Write a program that reads the information about a company and 
its manager and prints it back on the console.

 */

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Company fax Number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager First Name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager Last Name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Adress: " + companyAddress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web site: http://" + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
        Console.WriteLine();
    }
}