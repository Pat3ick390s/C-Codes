using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QantiferAssignment
{
    class Progarm
    {
        static void Main(string[] args)
        {
            Student[] students = {new Student {Name = "kim", Marks = 60},
                                  new Student {Name = "Patrick", Marks = 90},
                                  new Student {Name = "Samuel", Marks = 80}
            };
            //Using ALL METHOD.
            var query = students.All(students => students.Marks > 70);
            var Q = (from student in students
                     select student).All(x => x.Marks > 70);

            //Using ANY METHOD.
            List<int> numbers = new List<int>();
            var Available = numbers.Any();

            //Used the CONTAINS METHOD.
            List<string> Names = new List<string>() { "Patrick", "Samuel", "Obed", "Kim" };
            var Exist = Names.Contains("Daniel");

            Console.WriteLine();
        }
    }
}