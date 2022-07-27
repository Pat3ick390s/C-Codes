// See https://aka.ms/new-console-template for more information
namespace FeildsAndPropertyClassaWork
{
    class Progarm
    {
        static void Main(String [] args)
        {
            Human1 man = new Human1();
            man.EyeProperty = 1;
            man.LegProperty = 1;
            man.TeethProperty = 50;
            man.color = "Dark";

            Console.WriteLine(man.EyeProperty);
            Console.WriteLine(man.LegProperty);
            Console.WriteLine(man.TeethProperty);
            Console.WriteLine(man.color);
        }
    }
}
