using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        public string name { get; set; }

        private double balance;
        public double Balance { get { return balance; } set { balance += value; } }

        public double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }
        public double GetBalance()
        {
            return Balance += 1;
        }


    }
}
