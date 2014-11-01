namespace PCCatalogue
{
    using System;
    using System.Text;

    public class Component
    {
        //fields
        private string componentName;
        private decimal componentPrice;
        private string componentDetails;

        // constructors
        public Component()
        {
        }

        public Component(string componentName, decimal componentPrice, string componentDetails = null)
        {
            this.ComponentName = componentName;
            this.ComponentPrice = componentPrice;
            this.ComponentDetails = componentDetails;
        }

        // properties
        public string ComponentName
        {
            get
            {
                return this.componentName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("ComponentName should not be null or empty!");
                }
                this.componentName = value;
            }
        }

        public decimal ComponentPrice
        {
            get
            {
                return this.componentPrice;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("ComponentPrice value should positive and not zero.");
                }
                this.componentPrice = value;
            }
        }

        public string ComponentDetails
        {
            get { return this.componentDetails; }
            set { this.componentDetails = value; }
        }

        // console output
        public override string ToString()
        {
            var componentResult = new StringBuilder();
            componentResult.Append(string.Format("Component: {0} - Price {1:N} BGN", this.ComponentName, this.ComponentPrice));

            if (this.ComponentDetails != null)
            {
                componentResult.Append(string.Format(", Details {0}", this.ComponentDetails));
            }

            return componentResult.ToString();
        }
    }
}
