using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGroupWorkAirlineReservationSystem2
{
    public class Program
    {
        static void Main()
        {
            AirlineService airlineService = new AirlineService();
            while (true)
            {
                
                Console.WriteLine("[1] Add A Passenger.[2] Add A Flight. [3] Add a passenger to a flight. [4] View flight details");
                string op = Console.ReadLine();
                if (op == "1")
                {
                    Console.WriteLine("ENTER THE FIRST NAME OF THE PASSENGER");
                    var firstName = Console.ReadLine();
                    Console.WriteLine("ENTER THE LAST NAME OF THE PASSENGER");
                    var lastName = Console.ReadLine();
                    Console.WriteLine("ENTER THE PASSPORT NUMBER OF THE PASSENGER");
                    try
                    {
                        var phoneNumber = long.Parse(Console.ReadLine());
                        airlineService.RegisterAPassenger(phoneNumber, firstName, lastName);
                        Console.WriteLine("THE PASSENGER HAS BEEN SUCCESSFULLY REGISTERED");
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
                else if (op == "2")
                {
                    Console.WriteLine("ENTER THE FLIGHT NUMBER");
                    var flightnumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("DATE OF THE FLIGHT");
                    var dateofflight = Console.ReadLine();
                    Console.WriteLine("TAKE OFF");
                    var takeoff = Console.ReadLine();
                    Console.WriteLine("DESTINATION");
                    var destination = Console.ReadLine();
                    Console.WriteLine("Enter Aircraft Number");
                    var aircraftNumber = long.Parse(Console.ReadLine());
                    airlineService.AddAFlight(flightnumber, dateofflight, destination, takeoff, aircraftNumber);
                    Console.WriteLine("FLIGHT ADDED SUCCESSFULLY");

                }
                else if (op == "3")
                {

                    Console.WriteLine("ENTER THE PASSPORT NUMBER OF THE PASSENGER");
                    var passportnumber = long.Parse(Console.ReadLine());

                    Console.WriteLine("ENTER THE FLIGHT NUMBER YOU BOOKED FOR");
                    var flightnumber = long.Parse(Console.ReadLine());

                    airlineService.AddAPassengerToAFlight(passportnumber, flightnumber);
                    Console.WriteLine("PASSENGER HAVE BEEN ADDED TO THE FLIGHT.");
                }
                else if(op == "4")
                {
                    Console.WriteLine("Enter flight number to check details");
                    var details = long.Parse(Console.ReadLine());
                    var flightDetails = airlineService.ViewFlightDetails(details);
                    foreach(var flight in flightDetails)
                    {
                        Console.WriteLine($"FLIGHTNUMBER: {flight.Flight_Number} DATE OF FLIGHT: {flight.Date_Of_Flight} TAKE OFF: {flight.TakeOff} DESTINATION: {flight.Destination} PLANE: {flight.Planes.Name}");
                    }
                }
            }
        }
    }
}