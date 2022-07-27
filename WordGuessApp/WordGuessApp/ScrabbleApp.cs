using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessApp
{
    internal class ScrabbleWork
    {
        public string scrabble { get; set; }
        public string scrabble1 { get; set; }
        public string scrabble2 { get; set; }
        public string scrabble3 { get; set; }

        //public string scarbble4 { get; set; }

        public ScrabbleWork(string guess, string guess1, string guess2, string guess3)
        {
            scrabble = guess;
            scrabble1 = guess1;
            scrabble2 = guess2;
            scrabble3 = guess3;
            //scrabble4 = guess4;
        }
    }
}