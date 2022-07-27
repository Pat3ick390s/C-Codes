// See https://aka.ms/new-console-template for more information
Console.WriteLine("ADVANCE CACULATOR");

string num1;
string num2;
string op;
Console.WriteLine("Enter Two Numbers");

num1 = Console.ReadLine();
num2 = Console.ReadLine();
Console.WriteLine("The operator are +, -, *, /, %, ¬");
op = Console.ReadLine();

if (op == "+")

{
    Console.WriteLine("The Answer is");
    Console.WriteLine(int.Parse(num1) + int.Parse(num2));

}

else if (op == "-")
{
    Console.WriteLine("The Answer is");
    Console.WriteLine(int.Parse(num1) - int.Parse(num2));
}

else if (op == "*")
{
    Console.WriteLine("The Answer is");
    Console.WriteLine(int.Parse(num1) * int.Parse(num2));
}

else if (op == "/")
{
    Console.WriteLine("The Answer is");
    Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
}

else if (op == "%")
{
    Console.WriteLine("The Answer is");
    Console.WriteLine(int.Parse(num1) % int.Parse(num2));
}

else if (op == "¬")
{
    Console.WriteLine("The Answer is");
    Console.WriteLine(Math.Sqrt(int.Parse(num1) + int.Parse(num2)));
}

else

{
    Console.WriteLine("Enter a VAILD OPERATOR.!!");
}