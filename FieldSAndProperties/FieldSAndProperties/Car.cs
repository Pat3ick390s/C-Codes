using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldSAndProperties
{
    internal class Car
    {
        private int speed;
        private int wheel;
        public string color { get; set; }
        public int speedproperty
        {
            get { return speed; }
            set 
            {
                if (value > 250)
                {
                    speed = 250;
                }
                else
                {
                    speed = value;
                }
            }  
        }

        public int wheelproperty
        {
            get { return wheel; }
            set 
            {
                if (wheel > 4)
                {
                    wheel = 4;
                }
                else
                {
                    wheel = 4;
                }
            }

        }

        
    }
}
