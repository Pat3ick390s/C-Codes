using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModify
{
    internal class Car
    {
        public static int NumberOfCars;

        public Car ()
        {
            NumberOfCars++;
        }

        public static void Start()
        {
            Console.WriteLine("THE RACE HAS STARTED..!");
        }
    }
}
