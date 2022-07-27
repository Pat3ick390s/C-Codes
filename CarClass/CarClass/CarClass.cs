using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class CarClass
    {

        public string Name;

        public string Color;

        public string Brand;

        public string Model;

        public bool Tire;

        public CarClass()
        {

        }


        public CarClass (string Name, string Color, string Brand, string Model, bool Tire)
        {
            this.Name = Name;
            this.Color = Color;
            this. Brand = Brand;
            this.Model = Model;
            this.Tire = true;
        }
    }
}
