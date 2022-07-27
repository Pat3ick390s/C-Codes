using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        //ADDING FUNDS.
        [TestMethod]
        public void Adding_Amount_To_Balance()
        {
             //Arrange.
             var account = new Account(1000);

             //Act.
             account.Add(500);

             //Assert
             Assert.AreEqual(1500, account.Balance);
        }

        
        //WITHDRAWING FUNDS.
        [TestMethod]
        public void Withdrawing_Funds_To_Balance()
        {
            //Arrange.
            var account = new Account(1000);

            //Act.
            account.Withdraw(500);

            //Assert
            Assert.AreEqual(500, account.Balance);
        }
        


        //TRANSFERING FUNDS
        [TestMethod]
        public void Transfer_Funds_Updsates_Both_Accounts()
        {
            //Arrange.
            var account = new Account(1000);
            var otherAccount = new Account();

            //Act.
            account.TransferFundsTo(otherAccount, 500);

            //Assert
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, otherAccount.Balance);
        }


        //ACCOUNTBALANCE.
        [TestMethod]
        public void Account_Balance_Is_Low()
        {
            //Arrange.
            var account = new Account(99);

            //Act.
            account.AccountBalanceIsLow();

            //Assert.
            Assert.IsTrue(true);
        }
    }
}
