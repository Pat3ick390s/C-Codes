using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Theatre> theaters = new List<Theatre>()
        {
            new Theatre(){Name="Cinema",Capacity=2000,Location="Makurdi"},
            new Theatre(){Name="The Foundation Cinema",Capacity=1000,Location="Abuja"},
            new Theatre(){Name="The Palm Cinema",Capacity=500,Location="Benin"},
        };
            var movies = new List<Movie>();
            var viewers = new Dictionary<long, Viewer>();
            while (true)
            {
                Console.WriteLine("====================                    ====================                    ====================    ");
                Console.WriteLine("                                    Commands:Register Viewer, Add Movies, Sell Movies Tickets, View Movie Details");
                Console.WriteLine("====================                    ====================                    ====================    ");

                string options = Console.ReadLine();
                if (options.Equals("Register Viewer", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter Name Of Viewer");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter phone Number Of Viewer");
                    try
                    {
                        var phoneNumber = long.Parse(Console.ReadLine());
                        viewers.Add(phoneNumber, new Viewer { Name = name, PhoneNumber = phoneNumber });
                        Console.WriteLine("Viewer Registered Succesffully");
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                        Console.WriteLine("YOU CAN'T USE THESAME NUMBER !");
                    }
                }

                else if (options.Equals("Add Movies", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter Movie Title");
                    var movieTitle = Console.ReadLine();
                    Console.WriteLine("Enter Date Of Show");
                    var dateOfShow = Console.ReadLine();
                    Console.WriteLine("Enter Theatre Name");                    
                    try
                    {
                        var theatreName = Console.ReadLine();
                        var theatre = theaters.Where(x => x.Name == theatreName).First();

                        movies.Add(new Movie { movieTitle = movieTitle, DateOfShow = dateOfShow, Theater = theatre });
                        Console.WriteLine("Movie Added Succssfully !");
                    }
                    catch (Exception err)
                    {
                        //Console.WriteLine("Movie Added Succssfully !");
                        Console.WriteLine(err.Message);
                        Console.WriteLine("SORRY, THE THEATRE NAME DO NOT EXIST !");
                    }
                }

                else if (options.Equals("Sell Movies Tickets", StringComparison.OrdinalIgnoreCase))
                {

                    Console.WriteLine("Enter Phone number of viewr");
                    var phoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter movie begins payed for");
                    var movieTitle = Console.ReadLine();
                    try
                    {
                        var viewer = viewers[phoneNumber];
                        var movie = movies.Where(x => x.movieTitle == movieTitle).First();
                        movie.Viewers.Add(viewer);
                        Console.WriteLine("Viewer added successfully to this movie");
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                        Console.WriteLine("KINDLY ENTER THE CORRECT MOVIE NAME !");
                    }
                }

                else if (options.Equals("View Movie Details", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter movie title to check details");
                    try
                    {
                        var movieTitle = Console.ReadLine();
                        var movie = movies.Where(x => x.movieTitle == movieTitle).First();
                        Console.WriteLine($"Movie Title: {movieTitle}, Date Of Show: {movie.DateOfShow}, Thetre Of Play: {movie.Theater}");

                        //Display all viewers of this particular movie.
                        foreach (var viewer in movie.Viewers)
                        {
                            Console.WriteLine($"Name: {viewer.Name}, Phone Number: {viewer.PhoneNumber}, Email: {viewer.Email}");
                        }
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                        Console.WriteLine("YOU SKIPPED THE PROCESS, YOU CAN NOT VIEW THE MOVIE DETAILS");
                    }
                }

            }
        }
    }
}