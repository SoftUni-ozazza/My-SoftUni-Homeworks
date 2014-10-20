using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class SchoolMain
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            IList<Discipline> disciplines = new List<Discipline>(){new Discipline("geometry", 40, students)};
            

            Teacher teacherMath = new Teacher("Mathov", disciplines);
        }
    }
}
