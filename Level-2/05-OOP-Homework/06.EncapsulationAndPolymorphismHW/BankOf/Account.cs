using System;
using System.Collections.Generic;

namespace Bank
{
    public abstract class Account
    {
        private Customer accountHolder;
        private decimal balance;
        private decimal montlyInterestRate;

        public Account()
        {
        }

        public Account(Customer accountHolder, decimal balance, decimal montlyInterestRate)
        {
            this.AccountHolder = accountHolder;
            this.Balance = balance;
            this.MontlyInterestRate = montlyInterestRate;
        }

        public Customer AccountHolder
        {
            get
            {
                return this.accountHolder;

            }
            protected set
            {
                this.accountHolder = new Customer();
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }

        public decimal MontlyInterestRate
        {
            get
            {
                return this.montlyInterestRate;
            }
            protected set
            {
                if (value < 0.3m && value > 0.5m)
                {
                    throw new ArgumentException("montlyInterestRate", "Enter value in range 0.3 to 0.5.");
                }
                this.montlyInterestRate = value;
            }
        }

        public void DepositMoney(decimal sum)
        {
            this.Balance += sum;
            Console.WriteLine("Your balance is {0}", this.Balance);
        }

        public abstract void CalculatePeriodInterest(int months);

    }
}
