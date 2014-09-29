using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    public class GalacticGPS
    {
        static void Main()
        {
            Location home = new Location(12.123456, 10.123456, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
