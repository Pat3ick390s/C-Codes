// See https://aka.ms/new-console-template for more information
Console.WriteLine("DATE!, TIME!, ");




//static int Root(int p)
//{
//    return p * p * p;
//}
//Console.WriteLine(Root(10));
//Console.WriteLine("Hello, Today is " + Day + " and the time is " + Time + " You are in the year " + Date );

//string Day = "Monday";
//double Time = 12.09;
//double Date = 2022;








//static void omo()
//{
//    DateTime now = DateTime.Now;
//    Console.WriteLine("Hello, Today is " + (now.ToString("dddd")) + " and the time is " + (now.ToString("hh:mm tt")) + " You are in the year " + (now.ToString("yyyy")));
//}
//omo(); 

/*static void High(int num1);
{
    return 
}*/

static int High(int P, int S)
{
    if (P > S)
    {
        return P;
    }
    else if (S > P)
    {
        return S;
    }
    else
    {
        return 0;
    }
}
Console.WriteLine(High(10,50));