using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    class Point3D
    {
        //fields
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startingPoint;

        // properties
        public double X { get { return this.x; } set { this.x = value; } }
        public double Y { get { return this.y; } set { this.y = value; } }
        public double Z { get { return this.z; } set { this.z = value; } }
        public static Point3D StartingPoint { get { return Point3D.startingPoint; } }


        //constructors
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point3D()
        {
            startingPoint = new Point3D(0, 0, 0);
            Console.WriteLine(startingPoint);
        }

        // console output
        public override string ToString()
        {
            string resultPoint = String.Format("{{{0}, {1}, {2}}}", this.X, this.Y, this.Z).ToString();
            return resultPoint;
        }
    }
    
    // testing:
    //class MainProg
    //{
    //    static void Main(string[] args)
    //    {
    //        Point3D n = new Point3D(3, 12, 5.3452);
    //        Console.WriteLine(n);
    //    }
    //}
}