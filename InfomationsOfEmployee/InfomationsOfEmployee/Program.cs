using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InfomationsOfEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Student\Downloads\WorkingWithFiles\Contact.txt"; 

            string[] lines = File.ReadAllLines(path);

            List<Contact> contacts = new List<Contact>();

            foreach (var line in lines)
            {
                var spilt = line.Split(',');
                //var id = spilt[0];
                var name = spilt[0];
                var phonenumber = spilt[1];
                var email = spilt[2];
                var age = spilt[3];
                var degree = spilt[4];

                Contact contact = new Contact()
                {
                    //Id = int.Parse(id),
                    Name = name,
                    PhoneNumber = long.Parse(phonenumber),
                    Email = email,
                    Age = long.Parse(age),
                    Degree = bool.Parse(degree)
                };

                contacts.Add(contact);

                Console.WriteLine($"Name: {contact.Name}, PhoneNumber: {contact.PhoneNumber}, Email: {contact.Email}, Age: {contact.Age}, Degree: {contact.Degree}");

            }
            Console.ReadLine();
        }
    }
}