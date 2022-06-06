using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_App
{
    class Account
    {
        private decimal balance = 0;

        public bool withdraw(decimal amount)
        {
            if(balance < amount)
            {
                return false;
            }
            balance -= amount;
            return true;
        }

        public bool deposit(decimal amount)
        {
            if(amount <= 0)
            {
                return false;
            }
            balance += amount;
            return true;
        }

        public decimal getBalace()
        {
            return balance;
        }
    }
}
