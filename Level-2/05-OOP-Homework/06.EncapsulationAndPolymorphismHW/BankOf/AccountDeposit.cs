using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class AccountDeposit : Account
    {
        public override void CalculatePeriodInterest(int months)
        {
            decimal balanceMin = 0m;
            decimal balanceMax = 1000m;

            if (this.Balance > balanceMax)
            {
                decimal periodInterest = this.Balance * (1 + this.MontlyInterestRate * months);
                Console.WriteLine(periodInterest);
            }
            else if (this.Balance > balanceMin)
            {
                decimal periodInterest = 0;
                Console.WriteLine(periodInterest);
            }
        }

        public void WithdrawMoney(decimal sum)
        {
            if (this.Balance < sum)
            {
                Console.WriteLine("Insufficient amount of money at your balance!");
            }
            else
            {
                this.Balance -= sum;
                Console.WriteLine("Your balance is {0}", this.Balance);
            }
        }
    }
}
