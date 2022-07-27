// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("ADDITION");
string num1 = Console.ReadLine();

Console.WriteLine("ADDITION");
string num2 = Console.ReadLine();

Console.WriteLine("MULTIPILICATION");
string num3 = Console.ReadLine();

Console.WriteLine("SUBSTRICTION");
string num4 = Console.ReadLine();


int total = ((int.Parse(num1) + int.Parse(num2)) * int.Parse(num3) - int.Parse(num4));


Console.WriteLine("DIVISION");
string num5 = Console.ReadLine();

Console.WriteLine(total / int.Parse(num5));