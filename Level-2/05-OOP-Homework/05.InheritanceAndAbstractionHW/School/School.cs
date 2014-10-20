using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private IList<Class> classes;

        public School(IList<Class> classes)
        {
            this.Classes = classes;
        }

        public IList<Class> Classes { get; private set; }
    }
}
