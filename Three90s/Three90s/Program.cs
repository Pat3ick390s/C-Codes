// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Dictionary<string, string> phonebook = new Dictionary<string, string>();

while (true)
{
    string op;

    Console.WriteLine("KINDLY SELECT AN OPTION: SAVE, VIEW, UPDATE, DELECT");
    op = Console.ReadLine();

    //string name;
    //string number;

    if (op == "SAVE")
    {
        Console.WriteLine("ENTER YOUR NAME");
        string name = Console.ReadLine();

        Console.WriteLine("KINDLY ENTER YOUR PHONE NUMBER.");
        string number = Console.ReadLine();

        Console.WriteLine("YOUR CONTACT HAVE BEEN SAVED AS " + name);
        phonebook.Add(name, number);
        // Console.WriteLine();
        //phonebook = new Dictionary<string, string>();
    }

    else if (op == "VIEW")
    {

        Console.WriteLine("YOU SELECTED THE VIEW OPTION");
        Console.WriteLine("PLEASE ENTER YOUR NAME");

        string contactname = Console.ReadLine();
        if (phonebook.ContainsKey(contactname))
        {
            Console.WriteLine(phonebook[contactname]);
        }

        else
        {
            Console.WriteLine("SORRY, CONTACT DOES NOT EXIST");
        }

    }


    else if (op == "UPDATE")
    {
        Console.WriteLine("YOU SELECTED THE UPDATE OPTION");
        Console.WriteLine("PLEASE ENTER YOUR NAME YO UPDATE");
        string name = Console.ReadLine();
        Console.WriteLine("ENTER NEW NUMBER  TO UPDATE");
        string number = Console.ReadLine();
        phonebook[name] = number;
        Console.WriteLine(phonebook[name]);
        Console.WriteLine("YOUR NUMBER HAVE BEEN UPDATED SUCESSFULLY");

    }


    else if (op == "DELETE")
    {
        Console.WriteLine("YOU SELECTED THE UPDATE OPTION");
        Console.WriteLine("SELECT THE CONTACT NAME YOU WANT TO DELECT");
        string name = Console.ReadLine();
        phonebook.Remove(name);
        Console.WriteLine("THE NUMBER HAS BEEN SUCESSFULLY DELECTED");
    }


    else
    {
        Console.WriteLine("INVAILD COMMAND !!");
    }
}

//Dictionary<string, string> phonebook = new Dictionary<string, string>();
//while (true)
//{
//    Console.WriteLine("what would u like to do save, view, update, delete");
//    string op = Console.ReadLine();

    //    if (op == "save")
    //    {
    //        Console.WriteLine("u entered save");
    //        Console.WriteLine("enter contact name");
    //        string name = Console.ReadLine();

    //        Console.WriteLine("enter contact number");
    //        string number = Console.ReadLine();

    //        phonebook.Add(name, number);
    //        Console.WriteLine("" + name + " sucessfully saved");
    //    }


    //    else if (op == "VIEW")
    //    {

    //        Console.WriteLine("u entered view");
    //        Console.WriteLine("enter contact name to view");
    //        string contactname = Console.ReadLine();
    //        if (phonebook.ContainsKey(contactname))
    //        {
    //            Console.WriteLine(phonebook[contactname]);
    //        }
    //        else
    //        {
    //            Console.WriteLine("contact does not exist");
    //        }

    //    }


    //else if (op == "update")
    //{
    //    Console.WriteLine("u entered update");
    //    Console.WriteLine("enter contact name to update");
    //    string name = Console.ReadLine();
    //    Console.WriteLine("enter new number  to update");
    //    string number = Console.ReadLine();
    //    phonebook[name] = number;
    //    Console.WriteLine(phonebook[name]);
    //    Console.WriteLine("number updated sucessfully");


    //    /* Console.WriteLine(phonebook[update]);
    //    //myDictionary[myKey] = myNewValue;
    //    phonebook[update] = newnum;
    //    Console.WriteLine("phonenumber updated successfully");
    //    Console.WriteLine(phonebook[newnum]);*/
    //}


    //else if (op == "delete")
    //{
    //    Console.WriteLine("u entered delete");
    //    Console.WriteLine("enter contact name to delete");
    //    string name = Console.ReadLine();
    //    phonebook.Remove(name);
    //    Console.WriteLine("number deleted sucessfully");
    //}

//else
//{
//    Console.WriteLine("invalid command");
//}
//}