using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    public class BankAccount
    {
        public int balance { get; set; }
        private ILogBook _logBook;
        public BankAccount(ILogBook logBook)
        {
            balance = 0;
            _logBook = logBook;
        }

        public bool Deposit(int amount)
        {
            _logBook.Message("Deposit Invoked...");
            balance += amount;
            return true;
        }

        public bool Withdraw(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
