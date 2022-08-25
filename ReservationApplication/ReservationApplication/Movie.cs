using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApplication
{
    internal class Movie
    {
        public Movie()
        {
            Viewers = new List<Viewer>();
        }

        public string movieTitle { get; set; }
        public string Duration  { get; set; }
        public string DateOfShow { get; set; }
        public List<Viewer> Viewers { get; set; }
        public Theatre Theater { get; set; }
    }
}