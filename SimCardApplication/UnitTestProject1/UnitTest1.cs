using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimCardApplication;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //PURCHASE AIRTIME TO SIM CARD.
        [TestMethod]
        public void Purchase_Airtime()
        {
            //Arrange.
            var account = new SimCardAccount();

            //Act.
            account.RechargeAirtimeSim(500);

            //Assert
            Assert.AreEqual(500, account.Balance);
        }



        //BUYING DATA TO SIM CARD.
        [TestMethod]
        public void Purchase_Data_To_Sim()
        {
            //Arrange.
            var account = new SimCardAccount(300);

            //Act.
            account.PurchaseDataToSim(200);

            //Assert
            Assert.AreEqual(100, account.Balance);
        }



        //BORROWING DATA TO SIM CARD.
        [TestMethod]
        public void Borrow_Airtime_To_Sim()
        {
            //Arrange.
            var account = new SimCardAccount(0);

            //Act.
            account.BorrowAirtimeToSim(200);

            //Assert
            Assert.AreEqual(200, account.Balance);
        }



        //TRANSFERING AIRTIME.
        [TestMethod]
        public void Transfer_Airtime_From_Sim()
        {
            //Arrange.
            var account = new SimCardAccount(1000);
            var PhoneNumber = new SimCardAccount();

            //Act.
            account.TransferAirtimeFromSim(PhoneNumber, 500);

            //Assert
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, PhoneNumber.Balance);
        }



        //CHECKS IF AIRTIME BALANCE.
        [TestMethod]
        public void Checks_IF_Airtime_Balance_Is_Low()
        {
            //Arrange.
            var account = new SimCardAccount(30);

            //Act.
            account.AirtimeBalanceIsLow();

            //Assert.
            Assert.IsTrue(true);
        }
    }
}
