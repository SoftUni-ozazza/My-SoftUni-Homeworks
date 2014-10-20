using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Class : IDetails
    {
        private IList<Student> students;
        private IList<Teacher> teachers;
        private string textIndetifier;
        private string details;

        public Class(IList<Student> students, IList<Teacher> teachers, string textIndetifier)
        {
            this.Students = students;
            this.Teachers = teachers;
            this.TextIndetifier = textIndetifier;
        }

        public Class(IList<Student> students, IList<Teacher> teachers, string textIndetifier, string details)
            : this(students, teachers, textIndetifier)
        {
            this.details = details;
        }

        public IList<Student> Students { get; private set; }
        public IList<Teacher> Teachers { get; private set; }
        public string TextIndetifier { get; private set; }
        public string Details { get; set; }
    }
}
