using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompletePhoneBookApplication 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook contact = new PhoneBook();

            while (true)
            {
                Console.WriteLine("                            WELCOME TO PHONE BOOK APP");

                string userinput = Console.ReadLine();
                var spilt = userinput.Split();
                var opt = spilt[0];


                if (opt == "save")
                {
                    var name = spilt[1];
                    var phonenumber = spilt[2];
                    contact.Add(name, phonenumber);
                }
                else if (opt == "view")
                {
                    var name = spilt[1];
                    contact.View(name);
                }
                //else if (opt == "delete")
                //{
                //    var name = spilt[1];
                //    contact.Delete(name);
                //}
            }
        }
    }
}