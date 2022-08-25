using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGroupWorkAirlineReservationSystem2
{
    public class AirlineService
    {
        List<Plane> planes;
        List<Flight> flights;
        Dictionary<long, Passenger> passengers; 

        
         public AirlineService()
        {
            planes = new List<Plane>()
            {
                new Plane(){Name = "Emirates Airline", AirCraft_Number = 100023, NumberOfSeat = 700},
                new Plane(){Name = "Nigeria Fly", AirCraft_Number = 100033, NumberOfSeat = 600},
                new Plane(){Name = "The Eagle", AirCraft_Number = 100043, NumberOfSeat = 400}
            };

              flights = new List<Flight>();
              passengers = new Dictionary<long, Passenger>();
        }

        public bool RegisterAPassenger(long phonenumber, string firstName, string lastName)
        {
            var passenger = new Passenger() { First_Name=firstName, Last_Name=lastName, Passport_No=phonenumber};
            passengers.Add(phonenumber, passenger);
            return true;
            
        }
        public bool AddAFlight(long flightNumber,string takeOff,string destination,string dateOfFlight,long aircraftNumber)
        {
            var plane = planes.Where(x => x.AirCraft_Number == aircraftNumber).First();
            if (plane == null)
            {
                throw new Exception();
            }
            else
            {
                var flight = new Flight()
                {
                    Flight_Number = flightNumber,
                    TakeOff = takeOff,
                    Destination = destination,
                    Date_Of_Flight = dateOfFlight,
                    Planes = plane
                };

                flights.Add(flight);
                return true;
            }
        }
        public bool AddAPassengerToAFlight(long passportNumber, long flightNumber)
        {
            var passenger = passengers[passportNumber];
            var flight = flights.Where(x => x.Flight_Number == flightNumber).First();

            if (flights == null)
            {
                throw new Exception();
            }
            else
            {
                flight.Passengers.Add(passenger);
                return true;
            }
        }

        public IEnumerable<Flight> ViewFlightDetails(long flightNumber)
        {
            yield return flights.Where(x => x.Flight_Number == flightNumber).First();
            
        }
        public bool CheckIfPlaneExist(long airCraftNumber)
        {
            var plane = planes.Where(x => x.AirCraft_Number == airCraftNumber).FirstOrDefault();
            return true;
        }
    }
}
