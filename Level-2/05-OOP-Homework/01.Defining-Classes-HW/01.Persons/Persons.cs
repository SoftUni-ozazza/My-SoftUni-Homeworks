using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persons
{
    class PersonsMain
    {
        static void Main()
        {
            Person dev = new Person("Ivan", 24, "ivan@ivan.bg");
            Person writer = new Person("Boris", 29, "boris@boris.com");
            Person blogger = new Person("Grigor", 19);

            Console.WriteLine(dev);
            Console.WriteLine(writer);
            Console.WriteLine(blogger);
        }
    }
}