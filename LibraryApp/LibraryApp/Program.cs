Dictionary<string, string> books = new Dictionary<string, string>();
books.Add("1", "All Time High");
books.Add("2", "Ludo");
books.Add("3", "Ova");
books.Add("4", "Halleluyah");
books.Add("5", "My Identity");
books.Add("6", "The Experience");
while (true)
{
    Console.WriteLine("What Do You Want To Do... BORROW A Book, RETURN A Book");
    string opt = Console.ReadLine();
    if (opt == "borrow")
    {
        Console.WriteLine("Availiable books are...");
        foreach (var item in books)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("select no of book you want to borrow");
        string key = Console.ReadLine();
        if (books.ContainsKey(key))
        {
            Console.WriteLine($"{books[key]} borrowed out succesfully");
            books.Remove(key);
        }
        else
        {
            Console.WriteLine("Select A Valid Book Number");
        }
        foreach (var item in books)
        {
            Console.WriteLine(item);
        }
    }
    else if (opt == "return")
    {
        Console.WriteLine("How Many Days Did You Keep The Book");
        string days = Console.ReadLine();

        int fine = int.Parse(days) - 10;

        if (int.Parse(days) <= 10)
        {
            Console.WriteLine("Enter No On First Page Of book");
            string no = Console.ReadLine();
            Console.WriteLine("Enter Name Of book");
            string name = Console.ReadLine();

            if (books.ContainsKey(no))
            {
                Console.WriteLine($"{books[no]} Successfully Returned");
                books.Add(no, name);
            }
        }
        else if (int.Parse(days) >= 11 && int.Parse(days) <= 30)
        {
            Console.WriteLine("Book Successfully Returned");

            Console.WriteLine($"A Fine of {fine * 50} Is To Be Paid");
        }
        else if (int.Parse(days) >= 31)
        {
            Console.WriteLine($"A Fine of {fine * 100} Is To Be Paid");
        }
    }
}