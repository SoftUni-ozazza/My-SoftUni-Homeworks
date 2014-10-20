using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class AccountLoan : Account
    {
        public override void CalculatePeriodInterest(int months)
        {
            if (this.AccountHolder.CustomerType == "individual")
            {
                decimal periodInterest = this.Balance * (1 + this.MontlyInterestRate * (months - 3));
                Console.WriteLine(periodInterest);
            }
            else if (this.AccountHolder.CustomerType == "company")
            {
                decimal periodInterest = this.Balance * (1 + this.MontlyInterestRate * (months - 2));
                Console.WriteLine(periodInterest);
            }
        }
    }
}
