using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCardApp;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //RECHARGING TO SIM CARD.
        [TestMethod]
        public void Recharing_Sim_Card()
        {
            //Arrange.
            var account = new SimCardAccount();

            //Act.
            account.RechargeSim(500);

            //Assert
            Assert.AreEqual(500, account.Balance);
        }


        //BUYING DATA TO SIM CARD.
        [TestMethod]
        public void Buying_Data_To_Sim()
        {
            //Arrange.
            var account = new SimCardAccount();

            //Act.
            account.BuyDataToSim(500);

            //Assert
            Assert.AreEqual(10000, account.Balance);
        }
    }
}