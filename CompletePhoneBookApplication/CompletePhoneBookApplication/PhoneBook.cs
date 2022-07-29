using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompletePhoneBookApplication
{
    internal class PhoneBook
    {

        Dictionary<string, string> phonebook = new Dictionary<string, string>();


        public void Add(string name, string phonenumber)
        {

            phonebook.Add(name, phonenumber);
            Console.WriteLine("successful");

        }

        public void View(string name)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine(phonebook[name]);
            }
            else
            {
                Console.WriteLine("contact does not exist");
            }
        }

        //public void Update(string name)
        //{
        //    if (phonebook.ContainsKey(name))
        //    {
        //        phonebook.Remove(name);
        //    }
        //    else
        //    {
        //        Console.WriteLine("contact does not exist");
        //    }
        //}

        //public void Delete(string name)
        //{
        //    if (phonebook.ContainsKey(name))
        //    {
        //        phonebook.Remove(name);
        //        Console.WriteLine("contact successfully deleted");

        //    }
        //    else
        //    {
        //        Console.WriteLine("contact does not exist");
        //    }
        //}
    }
}