using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CompletePhoneBookApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextWriter path = new StreamWriter(@"C:\Users\Student\Videos\PhoneBook.txt", true);
    
            while (true)
            {
                Console.WriteLine("KINDLY SELECT THE METHOD YOU WANT TO OPERTE WITH: SAVE.");

                string option = Console.ReadLine();
                Console.WriteLine("KINDLY ENTER THE NAME AND PHONE NUMBER YOU WANT TO SAVE BELOW:");

                var contact = Console.ReadLine();
                var split = contact.Split(' ');
                var name = split[0];
                var phonenumber = split[1];

                if (option == "Save")
                {
                    path.Write($"Name: {name}  PhoneNumber: {phonenumber} \n\n");
                    Console.WriteLine($"THE CONTACT HAVE BEEN SAVED AS {name}");
                    path.Close();
                }
            }
        }
    }
}