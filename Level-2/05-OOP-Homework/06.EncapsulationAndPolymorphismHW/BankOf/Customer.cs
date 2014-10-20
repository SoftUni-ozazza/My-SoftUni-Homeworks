using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class Customer
    {
        private string name;
        private string customerType;

        public Customer()
        {
            this.Name = name;
            this.CustomerType = customerType;
        }

        public Customer(string name)
        {
            this.Name = name;
            this.CustomerType = customerType;
        }

        public Customer(string name, string customerType)
            : this(name)
        {
            this.CustomerType = customerType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Invalid name. Enter name.");
                }

                this.name = value;
            }
        }

        public string CustomerType
        {
            get
            {
                return this.customerType;
            }
            protected set
            {
                if (value != "individual" && value != "company")
                {
                    throw new ArgumentException("customerType", "Invalid value. Valid values: individual or company.");
                }

                this.customerType = value;
            }
        }

        public void AddCustomerName(string name)
        {
            this.Name += name;
        }

        public void AddCustomerType(string type)
        {
            this.CustomerType += type;
        }
    }
}
