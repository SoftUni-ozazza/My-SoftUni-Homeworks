using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : People
    {
        private IList<Discipline> disciplines;

        public Teacher(string name, IList<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, IList<Discipline> disciplines, string details)
            : base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public IList<Discipline> Disciplines { get; private set; }
    }
}
