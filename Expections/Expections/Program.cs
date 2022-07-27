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
    Console.WriteLine("SORRY, STRING NOT ALLOWED !");
}
catch (DivideByZeroException)
{
    Console.WriteLine("SORRY, YOU CAN'T DIVIDE BY ZERO !");
}
catch (Exception err)
{
    Console.WriteLine(err);
}
finally
{
    Console.WriteLine("THANK YOU FOR ATTEMPTING !");
}

for (int i = 0; i <= 1000000; i++)
{
    Console.WriteLine(i);
}