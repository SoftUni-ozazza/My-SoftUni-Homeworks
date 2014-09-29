using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longtitude;
        private Planet planet;

        // constructor
        public Location(double latitude, double longtitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set { this.latitude = value; }
        }

        public double Longtitude
        {
            get { return this.latitude; }
            set { this.latitude = value; }
        }

        public Planet Planet
        {
            get { return this.planet; }
            set { this.planet = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longtitude, this.Planet);
        }
    }
}
