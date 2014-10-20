using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : People
    {
        private int classNumber;

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, int classNumber, string details)
            : base(name, details)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber { get; private set; }
    }
}
