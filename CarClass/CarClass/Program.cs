// See https://aka.ms/new-console-template for more information
namespace CarClass
{
    class progarm
    {
        static void Main(string[] agrs)
        {

            CarClass Car1 = new CarClass();
            Car1.Name = "Toyota Camery";
            Car1.Color = "Ash";
            Car1.Brand = "Totota";
            Car1.Model = "Camery 360";
            Car1.Tire = true;


            CarClass Car2 = new CarClass();
            Car2.Name = "Lexus";
            Car2.Color = "Black";
            Car2.Brand = "Lexus";
            Car2.Model = "Lexus 360";
            Car2.Tire = true;


            CarClass Car3 = new CarClass();
            Car3.Name = "camry xse";
            Car3.Color = "White";
            Car3.Brand = "camry xse";
            Car3.Model = "xse ";
            Car3.Tire = true;


            CarClass Car4 = new CarClass("Koenigsegg Absolut", "Blue", "2023", "Horsepower.1280 hp @ 7800 rpm", true);
            Console.WriteLine(Car4.Name);
        }
    }
}



