using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop ibm = new Laptop("IBM Yoga Pro 2", 1799);
            Console.WriteLine(ibm);
            
            Laptop lenovo = new Laptop("Lenovo Yoga Pro 2", 1299, manufacturer: "lenovo", batDescription: "LI-Ion", batLife: "3.23");
            Console.WriteLine(lenovo);
        }
    }
}

// The error from the console:

// Unhandled Exception: System.NullReferenceException: Object reference not set to a
// n instance of an object.
//    at LaptopShop.Laptop.set_Processor(String value) in c:\Me\SoftUni Nakov\000 Le
// ctures\Homeworks\Level-2\05-OOP-Homework\01.Defining-Classes-HW\01.Laptop-Shop\La
// ptop.cs:line 103
//    at LaptopShop.Laptop..ctor(String model, Decimal price, String manufacturer, S
// tring processor, String ram, String graphicCard, String hdd, String batDescriptio
// n, String batLife, String screen) in c:\Me\SoftUni Nakov\000 Lectures\Homeworks\L
// evel-2\05-OOP-Homework\01.Defining-Classes-HW\01.Laptop-Shop\Laptop.cs:line 35
//    at LaptopShop.Laptop..ctor(String model, Decimal price, String manufacturer, S
// tring batDescription, String batLife) in c:\Me\SoftUni Nakov\000 Lectures\Homewor
// ks\Level-2\05-OOP-Homework\01.Defining-Classes-HW\01.Laptop-Shop\Laptop.cs:line 4
// 4
//    at LaptopShop.LaptopShop.Main(String[] args) in c:\Me\SoftUni Nakov\000 Lectur
// es\Homeworks\Level-2\05-OOP-Homework\01.Defining-Classes-HW\01.Laptop-Shop\Laptop
// Shop.cs:line 16
