using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompletePhoneBookApp
{
    internal class PhoneBook
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        //Adding Method.
        public void Add(string name, string phonenumber)
        {
            try
            {
                phonebook.Add(name, phonenumber);
                Console.WriteLine("Contact Saved Successful \n");
            }
            catch (Exception)
            {
                Console.WriteLine("Name Already Exist\n");
                Console.WriteLine("Failied");
            }
        }    
        //Viewing method.
        public void View(string name)
        {

            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine(phonebook[name] + "\n");
            }
            else
            {
                Console.WriteLine("Sorry, Contact Does Not Exist");
            }
        }
        //Update method.
        public void Update(string name, string phonenumber)
        { 
            if (phonebook.ContainsKey(name))
            {
                phonebook[name] = phonenumber;
                Console.WriteLine($"Name: {name} Succesfully Updated to {phonenumber} \n");
            }
            else
            {
                Console.WriteLine("Contact Already Exist ! \n");
            }
        }
        //Deleting Method.
        public void Delete(string name)
        {
            if (!phonebook.ContainsKey(name))
            {
                phonebook.Remove(name);
                Console.WriteLine("You Delected This Contact!! \n");
            }
            else
            {
                Console.WriteLine("Contact Already Exist! \n");
            }
        }
    }
}
