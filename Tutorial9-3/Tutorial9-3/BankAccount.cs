using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9_3
{
    class BankAccount
    {
        //field
        private decimal _balance;

        //constructor
        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        //balance property (read-only)
        public decimal Balance
        {
            get { return _balance; }
        }

        //deposit method
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        //withdraw method
        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }


    }
}
