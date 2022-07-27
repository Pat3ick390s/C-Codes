using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApp
{
    public class Account
    {
        private double balance;

        public Account()
        {
        }
        public Account(double balance)
        {
            this.balance = balance;  
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Add(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance -= amount;
        }

        public void TransferFundsTo(Account otherAccount, double amount)
        {
            if (otherAccount == null)
            {
                throw new ArgumentOutOfRangeException(nameof(otherAccount));
            }

            Withdraw(amount);
            otherAccount.Add(amount);
        }


        public bool AccountBalanceIsLow()
        {
            if(Balance < 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}