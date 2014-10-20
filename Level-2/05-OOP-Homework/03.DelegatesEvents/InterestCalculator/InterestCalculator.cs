using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class InterestCalculator
    {
        private decimal sum;
        private decimal interest;
        private int years;
        private decimal result;

        public decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            this.Result = this.Sum * (1 + this.Interest * this.Years);
            return this.Result;
        }

        public decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            double calcDouble = (double)(1 + (this.Interest / 12 / 100));
            this.Result = this.Sum * (decimal)Math.Pow(calcDouble, this.Years * 12);
            return this.Result;
        }

        public InterestCalculator(decimal sum, decimal interest, int years)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
        }

        public decimal Sum
        {
            get
            {
                return this.sum;
            }

            set
            {
                this.sum = value;
            }
        }

        public decimal Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value must be positive or zero.");
                }
                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The value must be positive.");
                }
                this.years = value;
            }
        }

        public decimal Result
        {
            get
            {
                return this.result;
            }
            set
            {
                this.result = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", sum, interest, years).ToString();
        }
    }
}
