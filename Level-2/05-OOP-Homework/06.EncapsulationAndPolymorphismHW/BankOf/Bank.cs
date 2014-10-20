using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class Bank
    {
        private IEnumerable<Account> accounts;
        private int accountsCounter;

        public IEnumerable<Account> Accounts { get; protected set; }
        public int AccountCounter { get; private set; }

        public Bank()
        {
            this.Accounts = accounts;
            this.AccountCounter = accountsCounter;
        }

        public void AddAccount()
        {
            Console.WriteLine("Wellcome to GlobalBank!");

        }

        // add account
        private void AddDepositAccount()
        {
            Account newAccount = new AccountDeposit();
        }

        private void AddLoanAccount()
        {
            Account newAccount = new AccountLoan();
        }

        private void AddMortgageAccount()
        {
            Account newAccount = new AccountMortgage();
        }

        // remove account
    }
}
