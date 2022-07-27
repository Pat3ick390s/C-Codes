// See https://aka.ms/new-console-template for more information
namespace StaticModify
{
    class Progarm
    {
        static void Main(String[] args)
        {
            Car Car1 = new  Car();
            Car Car2 = new Car();
            Car car3 = new Car();
            
            Console.WriteLine(Car.NumberOfCars);
            Car.Start();
        }
    }
    
}


