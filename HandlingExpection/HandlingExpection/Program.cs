try
{
    Console.WriteLine("INPUT FIRST NUMBER");
    string number1 = Console.ReadLine();

    Console.WriteLine("INPUT SECOND NUMBER");
    string number2 = Console.ReadLine();

    Console.WriteLine("FINALY ANSWER..!");
    Console.WriteLine((decimal)int.Parse(number1) / int.Parse(number2));
}
catch (FormatException)
{
    Console.WriteLine("SORRY, STRING NOT ALLOWED");
}