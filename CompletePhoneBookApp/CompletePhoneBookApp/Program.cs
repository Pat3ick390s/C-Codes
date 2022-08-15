using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CompletePhoneBookApp
{
    internal class Program
    {

        static void Main(string[] args)
        {       
            Console.WriteLine("                                ====================================");
            Console.WriteLine("                                WELCOME TO YOUR PHONEBOOK APPLICATION");
            Console.WriteLine("                                ====================================");
            PhoneBook Contact = new PhoneBook();

            while (true)
            {

                string UserInput = Console.ReadLine();
                var spilt = UserInput.Split();
                var option = spilt[0];

                if (option == "Save")
                {
                    var name = spilt[1];
                    var phonenumber = spilt[2];
                    Contact.Add(name, phonenumber);
                }

                else if (option == "View")
                {
                    var name = spilt[1];
                    Contact.View(name);
                }

                else if (option == "Update")
                {
                    var name = spilt[1];
                    var phonenumber = spilt[2];
                    Contact.Update(name, phonenumber);                  
                }
                else if(option == "Delete")
                {
                    var name = spilt[1];
                    //var phonenumber = spilt[2];
                    Contact.Delete(name);
                }
            }
        }
    }
}