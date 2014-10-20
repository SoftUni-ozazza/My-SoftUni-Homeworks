using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class AccountMortgage : Account
    {
        public override void CalculatePeriodInterest(int months)
        {
            int bonusMonthsIndivid = 6;
            int bonusMonthsCompany = 12;

            if (this.AccountHolder.CustomerType == "individual")
            {
                decimal periodInterest = this.Balance * (1 + (this.MontlyInterestRate/2) * bonusMonthsIndivid);
                periodInterest += this.Balance * (1 + (this.MontlyInterestRate) * months-bonusMonthsIndivid);
                
                Console.WriteLine(periodInterest);
            }
            else if (this.AccountHolder.CustomerType == "company")
            {
                decimal periodInterest = this.Balance * (1 + (this.MontlyInterestRate / 2) * bonusMonthsCompany);
                periodInterest += this.Balance * (1 + (this.MontlyInterestRate) * months - bonusMonthsCompany);

                Console.WriteLine(periodInterest);
            }
        }
    }
}
