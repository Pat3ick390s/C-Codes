using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardApp
{
    public class SimCardAccount
    {
        private double Airtimebalance;

        public SimCardAccount()
        {
        }
        public SimCardAccount(double Airtimebalance)
        {
            this.Airtimebalance = Airtimebalance;
        }

        public double Balance
        {
            get { return Airtimebalance; }
        }


        public void RechargeSim(double amount)
        {
            if (amount < 0 || amount > 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Airtimebalance += amount;
        }


        public void BuyDataToSim(double amount)
        {
            if (amount > Airtimebalance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Airtimebalance -= amount;
        }



        //public void BorrowAirtimeToYourSim(SIimCardApp otherAccount, double amount)
        //{
        //    if (otherAccount == null)
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(otherAccount));
        //    }

        //    SIimCardApp(amount);
        //    otherAccount.Add(amount);
        //}



        //public void Transfer_Airtime_To_Family(Account otherAccount, double amount)
        //{
        //    if (otherAccount == null)
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(otherAccount));
        //    }

        //    Withdraw(amount);
        //    otherAccount.Add(amount);
        //}
    }
}
