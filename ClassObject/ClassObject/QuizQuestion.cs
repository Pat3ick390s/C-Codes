using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    internal class QuizQuestion
    {
        public string Qestion { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }


        public QuizQuestion()
        {

        }

        public QuizQuestion (string quest, string OptA, string OptB, string OptC, string OptD, string Ans)
        {
            Qestion = quest;
            OptionA = OptA;
            OptionB = OptB;
            OptionC = OptC;
            OptionD = OptD;
            Answer = Ans;
        }

    }
}
