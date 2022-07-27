using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////QUESTION NUMBER 1;
//-Were
//-OfType
//CORRECT

////QUESTION NUMBER 2;
//Types Of Projection.
//-Selct
//-SelectMany
//CORRECT


////QUESTION NUMBER 4;
//-SORTING OPERTOR: Is used to mange data in a particular order, it may be ascending or decsending order.
//CORRECT

//THE TYPES OF OPERTOR ARE LISTED BELOW;

//-OrderBy.
//-OrderByAsending.
//-ThenBy.
//-ThenByDesending.
//-Reverse.
//CORECT

namespace LinqAssignment
{
    class Progarm
    {
        static void Main(string[] args)
        {
            //SELECT METHOD.
            Console.WriteLine("..................ALL THIS LIST OF ITEMS............");
            var dataSource = new List<object>() {"Patrick", "Samuel", "John", "Kim", "Jacob", 2, 1, 4, 3, 6, 5, 8, 7, 10}; //CORRECT
            var methodSytnax1 = dataSource.Select(x => x).ToList(); //FAILED
            foreach (var item in methodSytnax1)
            {
                Console.WriteLine(item);
            }

            //OF-TYPE,WHERE METHOD.
            Console.WriteLine("..................DISPLAYING NAMES GREATER THAN 5 LATTER............");
            var methodSytnax2 = dataSource.OfType<string>().Where(x => x.Length > 5).ToList(); //CORRECT
            foreach (var item in methodSytnax2)
            {
                Console.WriteLine(item);
            }

            //ORDER-BY ASCENDING METHOD.
            Console.WriteLine("..................ORDER-BY- ASCENDING ORDER............");
            var DataS = new List<int>() { 2, 1, 4, 3, 6, 5, 8, 7, 10 };
            var MethodS = DataS.OrderBy(x => x).ToList(); //CORRECT
            foreach (var item in MethodS)
            {
                Console.WriteLine(item);
            }

            //ORDER-BY DESCENDING METHOD.
            Console.WriteLine("..................ORDER-BY- DESCENDING ORDER............");
            var MS = DataS.OrderByDescending(x => x).ToList(); //CORRECT
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }


            //  THEN-BY & ORDER-BY.
            Console.WriteLine("..................THEN-BY AND ORDER-BY............");
            List<Assignment> names = new List<Assignment>()
            {
                new Assignment(){FristName = "Patrick", LastName = "Eche"},
                new Assignment(){FristName = "Samuel", LastName = "Opi"},
                new Assignment(){FristName = "Daniel", LastName = "Oma"}
            };
            var Msytnax = names.OrderBy(x => x.LastName).ThenByDescending(x => x.FristName).ToList(); //CORRECT

            foreach (var item in names)
            {
                Console.WriteLine($"{item.FristName} {item.LastName}");
            }


            //  REVERSE.
            Console.WriteLine("..................USING REVERSE METHOD............");
            int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //CORRECT

            var MethodQuery = number.Reverse();
            foreach (var item in MethodQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}