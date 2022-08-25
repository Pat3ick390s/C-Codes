using ClassGroupWorkAirlineReservationSystem2;

namespace TestProject1
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void Test_To_Register_Passenger()
        {
            //Arrange
            var airLine = new AirlineService();

            //Act
            var result = airLine.RegisterAPassenger(1000, "Abby", "Ochezzz");

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
    public void Test_To_Add_Flight()
    {
        //Arrange
        var airLine = new AirlineService();

        //Act
        var result = airLine.AddAFlight(1000, "lagos", "abuja", "22 nov 2022", 100023);

        //Assert
        Assert.IsTrue(result);
    }

    [Test]
        public void Test_To_Add_A_Passenger_To_Flight()
        {
            //Arrange
            var airLine = new AirlineService();

            //Act
            airLine.RegisterAPassenger(1234, "Abby", "Ochezzz");
            airLine.AddAFlight(1000, "lagos", "abuja", "22 nov 2022", 100023);
            var result = airLine.AddAPassengerToAFlight(1234, 1000);

            //Assert
            Assert.IsTrue(result);
        }

    [Test]
        public void IfPlaneExistReturnTrue()
        {
            //Arrange
            var airLine = new AirlineService();

            //Act
            airLine.AddAFlight(1000, "lagos", "abuja", "22 nov 2022", 100023);
            var result = airLine.CheckIfPlaneExist(100023);

            //Assert
            Assert.IsTrue(result);
        }
    }
}