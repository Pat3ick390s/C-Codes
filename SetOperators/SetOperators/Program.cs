using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperators
{
    class Progarm
    {
        static void Main(string[] args)
        {
            ///////////////////////
            //DISTINCT SET METHOD.
            List<int> number = new List<int>() { 1, 2, 3, 1, 3, 2, 4, 3, 5, 5};
            
            var MS = number.Distinct().ToList();
            var Qs =(from num in number
                     select num).Distinct().ToList();

            List<Student> students = new List<Student>()
            {
            new Student() { Id = 1, Name = "Patrick" },
            new Student() { Id = 2,Name = "Samuel" },
            new Student(){Id = 1, Name = "Mark" },
            new Student() { Id = 3,Name = "Kim" },
            new Student() { Id = 3,Name = "Kim" },
            };
      
            var MethodSyntax = students.Select(x => x.Name).Distinct().ToList();

         ///////////////////////
            //EXCEPT METHOD.
            List<Student> students1= new List<Student>()
            {
            new Student() { Id = 1, Name = "Patrick" },
            new Student() { Id = 2,Name = "Samuel" },
            new Student(){Id = 1, Name = "Mark" },
            new Student() { Id = 3,Name = "Kim" },
            new Student() { Id = 3,Name = "Peace" },
            };

            List<Student> students2 = new List<Student>()
            {
            new Student() { Id = 1, Name = "Patrick" },
            new Student() { Id = 2,Name = "Samuel" },
            new Student(){Id = 1, Name = "Mark" },
            new Student() { Id = 3,Name = "John" },
            new Student() { Id = 3,Name = "Peace" },
            };

            var methodsyntax = students1.Select(x=> x.Name).Except(students2.Select(x=> x.Name)).ToList();



            //////////////////////
            //INTERSECT SET METHOD.
            List<string> name1 = new List<string>() { "Ahem", "Samuel", "Kim", "Patrick", "Jacob" };
            List<string> name2 = new List<string>() { "John", "Samuel", "Creda", "Patrick", "Jacob" };

            var ms =  name1.Intersect(name2).ToList();

            var mixS =(from stu in name2
                       select stu).Intersect(name1).ToList();



            /////////////////////
            //UNION SET METHOD.
            List<string> DataSource1 = new List<string>() { "A", "B", "C", "D", "E" };
            List<string> DataSource2 = new List<string>() { "D", "E", "F", "G", "H" };

            var method = DataSource1.Union(DataSource2).ToList();

            //COMPLEX EXAMPLES..
            List<Student1> Data1 = new List<Student1>()
            {
            new Student1() { Id = 1, Name = "Patrick" },
            new Student1() { Id = 2,Name = "Samuel" },
            new Student1(){Id = 1, Name = "Mark" },
            new Student1() { Id = 3,Name = "Kim" },
            new Student1() { Id = 3,Name = "Peace" },
            };

            List<Student1> Data2 = new List<Student1>()
            {
            new Student1() { Id = 1, Name = "Patrick" },
            new Student1() { Id = 2,Name = "Samuel" },
            new Student1(){Id = 1, Name = "Mark" },
            new Student1() { Id = 3,Name = "John" },
            new Student1() { Id = 3,Name = "Peace" },

            };
            var MSyntax = Data1.Union(Data2, new Student1()).ToList();

            //OR YPU CAN USE THE ANNONIMUS TYPE.
            var methodSyntax = Data1.Select(X=> new {X.Id, X.Name}).Union(Data2.Select(X => new { X.Id, X.Name })).ToList();

            Console.WriteLine();
        }
    }
}