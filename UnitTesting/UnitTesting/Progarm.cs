using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Account
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
                    throw new ArgumentException(nameof(amount));
                }

                if (amount < 0)
                {
                throw new ArgumentException(nameof(amount));
                }

                balance += amount;
            }  
        
            public void TransferFundsTo(Account otherAcount, double amount)
            {
                if (otherAcount == null)
                {
                    throw new ArgumentException(nameof(otherAcount));
                }

                Withdraw(amount);
                otherAcount.Add(amount);
            }

            public void AccountBalance(double amount)
            {
                if (balance < amount || balance == 0)
                {
              
                }

            }
    }
}
