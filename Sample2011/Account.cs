using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Account
    {
        private decimal _balance;


        public Account(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public decimal Deposit(decimal amount)
        {
            _balance += amount;
            return _balance;
        }

        
        public decimal Withdraw(decimal amount)
        {
            _balance -= amount;
            return _balance;
        }
    }
}
