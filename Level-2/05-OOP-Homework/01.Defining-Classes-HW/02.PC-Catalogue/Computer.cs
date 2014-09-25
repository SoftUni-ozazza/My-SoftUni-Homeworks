using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalogue
{
    class Computer
    {
        private string name;
        private List<Component> components = new List<Component>();


        //constructors
        public Computer(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Computer(string name, string motherboard = null, decimal price) : this(name, price)
        {
            this.Component.name = motherboard;
            this.Component.price = partPrice;
        }

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == "" || value == " ")
                {
                    throw new ApplicationException("The value can not be null or empty.");
                }
                this.name = value;
            }
        }

        //public decimal Price
        //{
        //    get
        //    {
        //        return this.price;
        //    }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ApplicationException("The value can not be null /or/ empty, or negative.");
        //        }
        //        this.price = value;
        //    }
        //}

        public string Motherboard
        {
            get
            {
                return this.motherboard;
            }
            set
            {
                if (value == " ")
                {
                    throw new ApplicationException("The value can not be a whitespace!");
                }
                this.motherboard = value;
            }
        }

        //string output


    }
}