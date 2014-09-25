using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalogue
{
    class Component
    {
        //fields
        private string name;
        private decimal price;
        private string details; //opt

        // constructors
        public Component() { }

        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        // properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Name can not be null or empty!");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Price value can not be negative");
                }
                this.price = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        // console output
        public override string ToString()
        {
            string result = string.Format("Name {0}, Price {1}", this.Name, this.Price);

            if (this.Details != null)
            {
                result += string.Format(", Details {0}", this.Details);
            }

            return result;
        }
    }
}
