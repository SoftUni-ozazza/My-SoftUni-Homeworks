using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline : IDetails
    {
        private string disciplineName;
        private int numberOfLectures;
        private IList<Student> students;
        private string details;

        public Discipline(string disciplineName, int numberOfLectures, IList<Student> students)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
        }

        public Discipline(string disciplineName, int numberOfLectures, IList<Student> students, string details)
            : this(disciplineName, numberOfLectures, students)
        {
            this.Details = details;
        }

        public string DisciplineName { get; private set; }
        public int NumberOfLectures { get; private set; }
        public IList<Student> Students { get; private set; }
        public string Details { get; set; }


    }
}
