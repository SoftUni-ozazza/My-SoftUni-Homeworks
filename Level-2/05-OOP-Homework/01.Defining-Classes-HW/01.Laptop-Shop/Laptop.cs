using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        //Fields
        private string model;
        private decimal price;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private Battery battery = new Battery();

        // Constructors:
            // Mandatory
        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

            // Non-Mandatory
        public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram = null, string graphicCard = null, string hdd = null, string batDescription = null, string batLife = null, string screen = null)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.Hdd = hdd;
            this.Battery.Description = batDescription;
            this.Battery.LifeInHours = batLife;
            this.Screen = screen;
        }

        public Laptop(string model, decimal price, string manufacturer = null, string batDescription = null, string batLife = null)
            : this(model, price, manufacturer, null, null, null, null,batDescription, batLife) {}

        // Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("String value can not be empty.");
                }
                this.model = value;
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
                    throw new ArgumentOutOfRangeException("Value can not be negative.");
                }
                this.price = value;
            }
        }

        //non-mandatory
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Equals(" "))
                {
                    throw new ApplicationException("String value can not be empty.");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value.Equals(" "))
                {
                    throw new ApplicationException("String value can not be empty.");
                }
                this.processor = value;
            }
        }
        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value.Equals(" "))
                {
                    throw new ApplicationException("String value can not be empty.");
                }
                this.ram = value;
            }
        }
        public string GraphicCard
        {
            get
            {
                return this.graphicCard;
            }
            set
            {
                if (value.Equals(" "))
                {
                    throw new ApplicationException("String value can not be empty.");
                }
                this.graphicCard = value;
            }
        }
        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value.Equals(" "))
                {
                    throw new ApplicationException("String value can not be empty.");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value.Equals(" "))
                {
                    throw new ApplicationException("String value can not be empty.");
                }
                this.screen = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        // enabling console output
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.Model);
            result.AppendLine(this.Price.ToString() + " lv.");

            if (this.Manufacturer != null)
            {
                result.AppendLine(this.Manufacturer);
            }
            if (this.Processor != null)
            {
                result.AppendLine(this.Processor);
            }
            if (this.Ram != null)
            {
                result.AppendLine(this.Ram);
            }
            if (this.GraphicCard != null)
            {
                result.AppendLine(this.GraphicCard);
            }
            if (this.Hdd != null)
            {
                result.AppendLine(this.Hdd);
            }
            if (this.Screen != null)
            {
                result.AppendLine(this.Screen);
            }
            if (this.Battery != null)
            {
                result.AppendLine(this.Battery.ToString());
            }

            return result.ToString();
        }

    }
}
