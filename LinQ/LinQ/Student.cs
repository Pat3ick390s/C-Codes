using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Student
    {
        public string Fristname { get; set; }

        public string Surname { get; set; }

        public string CurrentClass { get; set; }

        public double ResultAverage { get; set; }


        public Student (string Frist, string Sur_name, string Current_Class, double Result_Average)
        {
            Fristname = Frist;
            Surname = Sur_name;
            CurrentClass = Current_Class;
            ResultAverage = Result_Average;
        }
    }
}
