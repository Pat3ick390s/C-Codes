// See https://aka.ms/new-console-template for more information
namespace FieldSAndProperties
{
    class Progarm
    {
        static void Main(String[] args)
        {
            Car Car1 = new Car();
            Car1.speedproperty = 5000;
            Car1.wheelproperty = 5;
            Car1.color = "Blue";

            Console.WriteLine(Car1.speedproperty);
            Console.WriteLine(Car1.wheelproperty);
            Console.WriteLine(Car1.color);
        }
        
    }
}