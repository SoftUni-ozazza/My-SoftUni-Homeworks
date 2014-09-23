using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Person
    {
        // Fields
        private string name;
        private int age;
        private string email = null;

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException(
                        "The value of name is null or empty");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                // validation
                if ((this.age < 0) || (this.age > 100))
                {
                    throw new ArgumentOutOfRangeException(
                        "The valid values are in the range [0..100]");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null ||
                   ((!value.Equals("") && !value.Equals(" ")) && value.Contains("@")))
                {
                    this.email = value;
                }
            }
        }

        // Call the properties:
        // Constructor 1 
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        // Constructor 2
        public Person(string name, int age) : this(name, age, null) { }

        // Enableing Person to be writen at the console
        public override string ToString()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                return string.Format("The person is {0} at {1}.", this.Name, this.Age);
            }
            else
            {
                return string.Format("The person is {0} at {1} with email {2}.", this.Name, this.Age, this.Email);
            }
        }
    }
}
