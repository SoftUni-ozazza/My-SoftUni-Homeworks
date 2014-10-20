using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class People : IDetails
    {
        private string name;
        private string details;

        public People(string name)
        {
            this.Name = name;
        }

        public People(string name, string details)
            : this(name)
        {
            this.Details = details;
        }

        public string Name { get; private set; }
        public string Details { get; set; }
    }
}
