// See https://aka.ms/new-console-template for more information
Console.WriteLine("QUIZ APP");

Dictionary<string, int> quiz = new Dictionary<string, int>();

while (true)
{
    string f1st;

    Console.WriteLine("ANSWER THE QUESTION BELOW.");
    Console.WriteLine("(Q1)  How many days are in a week ??____ [A]. 4  [B]. 3  [C].  6   [D]. 7");
    //Console.WriteLine("[A]. FOUR");
    //Console.WriteLine("[B]. THREE");
    //Console.WriteLine("[C]. SIX");
    //Console.WriteLine("[D]. SEVEN");
    f1st = Console.ReadLine();

    if (f1st == "D")

    {
        quiz.Add("D", 2);
        Console.WriteLine("CORRECT");
        Console.WriteLine("You scored 2");
    }

    else if (f1st == "D")
    {

        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (f1st == "A")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (f1st == "B")
    {
        Console.WriteLine("WRONG !");
        //Console.WriteLine("You scored 0");
    }

    else
    {
        Console.WriteLine("KINDLY SELECT A OPTION ABOVE..");
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    string s2nd;

    Console.WriteLine("ANSWER THE QUESTION BELOW.");
    Console.WriteLine("(Q2)  At what age are you expected to have account with the Bank ??____ [A]. 10   [B]. 5  [C]. 18   [D]. 17");
    //Console.WriteLine("[A]. 10");
    //Console.WriteLine("[B]. 5");
    //Console.WriteLine("[C]. 18");
    //Console.WriteLine("[D]. 17");
    s2nd = Console.ReadLine();



    if (s2nd == "C")

    {
        quiz.Add("G", 2);
        Console.WriteLine("CORRECT");
        Console.WriteLine("You scored 2");
    }

    else if (s2nd == "D")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (s2nd == "A")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (s2nd == "B")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else
    {
        Console.WriteLine("KINDLY SELECT A OPTION ABOVE..");
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    string t3rd;

    Console.WriteLine("ANSWER THE QUESTION BELOW.");
    Console.WriteLine("(Q3)  How many planets do we have ??____ [A]. 8   [B]. 5   [C]. 18   [D]. 17");
    //Console.WriteLine("[A]. 8");
    //Console.WriteLine("[B]. 5");
    //Console.WriteLine("[C]. 18");
    //Console.WriteLine("[D]. 17");
    t3rd = Console.ReadLine();



    if (t3rd == "A")

    {
        quiz.Add("A", 2);
        Console.WriteLine("CORRECT");
        Console.WriteLine("You scored 2");
    }

    else if (t3rd == "D")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (t3rd == "C")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (t3rd == "B")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else
    {
        Console.WriteLine("KINDLY SELECT A OPTION ABOVE..");
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    string f4th;

    Console.WriteLine("ANSWER THE QUESTION BELOW.");
    Console.WriteLine("(Q4)	Who is the father of Computer science?____ [A]. Pat3ick Eche   [B]. Charles Babbage   [C]. Samuel imanche   [D]. Mr Daniel");
    //Console.WriteLine("[A]. Pat3ick Eche");
    //Console.WriteLine("[B]. Charles Babbage");
    //Console.WriteLine("[C]. Samuel imanche");
    //Console.WriteLine("[D]. Mr Daniel");
    f4th = Console.ReadLine();



    if (f4th == "B")

    {
        quiz.Add("B", 2);
        Console.WriteLine("CORRECT");
        Console.WriteLine("You scored 2");
    }

    else if (f4th == "D")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (f4th == "C")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (f4th == "A")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else
    {
        Console.WriteLine("KINDLY SELECT A OPTION ABOVE..");
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    string f5th;

    Console.WriteLine("ANSWER THE QUESTION BELOW.");
    Console.WriteLine("(Q5) In a computer, most processing takes place in ?____ [A]. Joystick   [B].Keyboard   [C]. Monitor   [D]. CPU");
    //Console.WriteLine("[A]. Joystick");
    //Console.WriteLine("[B].Keyboard");
    //Console.WriteLine("[C]. Monitor");
    //Console.WriteLine("[D]. CPU");
    f5th = Console.ReadLine();



    if (f5th == "D")

    {
        quiz.Add("D", 2);
        Console.WriteLine("CORRECT");
        Console.WriteLine("You scored 2");
    }

    else if (f5th == "B")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (f5th == "C")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else if (f5th == "A")
    {
        Console.WriteLine("WRONG !");
        Console.WriteLine("You scored 0");
    }

    else
    {
        Console.WriteLine("KINDLY SELECT A OPTION ABOVE..");

    }
    Console.WriteLine("TOTAL SCORE");
    var total = quiz.Sum(x => x.Value);
    Console.WriteLine(total);

    break;
}



