using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAssignment_On_Class_and_Object
{
    internal class Annimals
    {

        public string name { get; set; }

        public bool Movemnt { get; set; }

        public string Habitat { get; set; }

        public bool Horn { get; set; }

        public string Class { get; set; }

        public int hand { get; set; }

        public int Legs { get; set; }

        public int Eye { get; set; }


        public Annimals()
        {
        
        }

        public Annimals(string name, string Class, bool Movemnt, string Habitat, bool Horn,  int Hand, int Legs, int Eye)
        {
           this.name = name;
            Class = Class;
            Movemnt = true;
            Habitat = Habitat;
            Horn = true;
            Hand = 2;
            Legs = 0;
            Eye = 2;
        }
    }
}