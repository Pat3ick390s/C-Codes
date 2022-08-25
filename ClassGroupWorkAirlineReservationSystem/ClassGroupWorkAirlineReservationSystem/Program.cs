using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassGroupWorkAirlineReservationSystem
{
    internal class Program
    {
        static void Main()
        {
            var plane = new List<Plane>()
            {
                new Plane(){Name = "427 Airline", AirCraftNumber = 390, NumberOfSeat = 700},
                new Plane(){Name = "Foundation Airline", AirCraftNumber = 340, NumberOfSeat = 700},
                new Plane(){Name = "Emirates Airline", AirCraftNumber = 360, NumberOfSeat = 700}
            };

            var flights = new List<Flight>();
            var passengers = new Dictionary<long, Passenger>();

            while (true)
            {
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("===                                  WELCOME TO OUR AIRLINE MANAGEMENT SYSTEM                  ===");
                Console.WriteLine("==================================================================================================\n\n");

                Console.WriteLine("OPERATIONS: Register A Passenger :    Add A Flight :    Add A Passenger To A Flight :    View Flight Details \n\n\n");
                var options = Console.ReadLine();

                if(options.Equals("Register A Passenger", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("ENTER YOUR FIRST NAME");
                    var firstname = Console.ReadLine();
                    Console.WriteLine("ENTER YOUR LAST NAME");
                    var lastname = Console.ReadLine();
                    Console.WriteLine("ENTER THE NUMBER ON YOUR PASSPORT");
                    try
                    {
                        var passportnumber = long.Parse(Console.ReadLine());
                        passengers.Add(passportnumber, new Passenger { FirstName = firstname, LastName = lastname, PassportNumber = passportnumber });
                        Console.WriteLine("THE PASSENGER HAS BEEN SUCCESSFULLY REGISTERED\n\n");
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                   
                }
                else if(options.Equals("Add A Flight", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("ENTER THE FLIGHT NUMBER");
                    var flightnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("DATE OF THE FLIGHT");
                    var dateofflight = Console.ReadLine();
                    Console.WriteLine("WHERE ARE YOU TAKING-OFF FROM?");
                    var takeoff = Console.ReadLine();
                    Console.WriteLine("WHERE'S YOUR DESTINATION");
                    var destination = Console.ReadLine();

                    try
                    {
                        flights.Add(new Flight { FlightNumber = flightnumber, DateOfFlight = dateofflight, TakeOff = takeoff, Destination = destination });
                        Console.WriteLine("THE FLIGHT HAS BEEN ADDED SUCCESSFULLY\n\n");
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }                                      

                }
                else if (options.Equals("Add A Passenger To A Flight", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("ENTER THE PASSPORT NUMBER OF THE PASSENGER");
                    var passportnumber = long.Parse(Console.ReadLine());
                    
                    
                    Console.WriteLine("ENTER THE FLIGHT NUMBER YOU BOOKED FOR");
                    var flightnumber = long.Parse(Console.ReadLine());
                    try
                    {
                        var passenger = passengers[passportnumber];
                        var flight = flights.Where(x => x.FlightNumber == flightnumber).First();
                        flight.passengers.Add(passenger);
                        Console.WriteLine("THE PASSENGER HAS BEEN SUCCESSFULLY ADDED TO THE FLIGHT\n\n");
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                    
                }
                else if (options.Equals("View Flight Details", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("ENTER THE FLIGHT NUMBER TO CHECK DETAILS");
                    var flightnumber = long.Parse(Console.ReadLine());
                    try
                    {
                        var flight = flights.Where(x => x.FlightNumber == flightnumber).First();
                        Console.WriteLine($"\n  Flight Number: {flight.FlightNumber}\n  Date of the flight:  {flight.DateOfFlight}\n  Take off:   {flight.TakeOff}\n  Destination: {flight.Destination}\n  Plane boarding the flight: {flight.planes}\n  AirPlane Name: {flight.FlightNumber}\n");

                        foreach (var pass in flight.passengers)
                        {
                            Console.WriteLine($"\n  First Name:  {pass.FirstName}\n  Last Name: {pass.LastName}\n  Passport Number:  {pass.PassportNumber}");
                        }
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                    
                }
            }
        }
    }
}