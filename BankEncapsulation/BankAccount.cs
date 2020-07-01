using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        public string name { get; set; }

        private double _balance;
        public double Balance { get { return _balance; } set { _balance += value; } }

        public double Deposit(double amount)
        {
            _balance += amount;
            return _balance;
        }
        public double GetBalance()
        {
            return Balance += 1;
        }


    }
}
