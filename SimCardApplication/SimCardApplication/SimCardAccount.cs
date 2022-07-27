using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardApplication
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

        // Recharing Airtime To Sim!
        public void RechargeAirtimeSim(double amount)
        {
            if (amount < 0 || amount > 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Airtimebalance += amount;
        }

        //Purchasing Airtime From Sim!
        public void PurchaseDataToSim(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Airtimebalance -= amount;
        }

        //Borrowing Airtime From Sim!
        public void BorrowAirtimeToSim(double amount)
        {
            if (Balance != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Airtimebalance += amount;
        }

        // Duducting Transfered Airtime while transfering Airtime to friends & Family!
        public void DuductTransferedAirtime(double amount)
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

        //Transfering Airtime To Family And Friends!
        public void TransferAirtimeFromSim(SimCardAccount PhoneNumber, double amount)
        {
            if (PhoneNumber == null)
            {
                throw new ArgumentOutOfRangeException(nameof(PhoneNumber));
            }

            DuductTransferedAirtime(amount);
            PhoneNumber.RechargeAirtimeSim(amount);
        }

        //Checks IF Airtime Blance Is LOW..
        public bool AirtimeBalanceIsLow()
        {
            if (Balance > 20)
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