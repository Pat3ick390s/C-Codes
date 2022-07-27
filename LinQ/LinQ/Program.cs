using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Progarm
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>()
            {
                new Student("Samuel", "Akpa", "JSS1", 50.7),
                new Student("John", "Musa", "JSS2", 70.1),
                new Student("Peter", "Agbo", "JSS3", 49.7),
                new Student("Simon", "Sunday", "SS1", 44.5),
                new Student("Esther", "Omo", "SS2", 70.1),
                new Student("Patrick", "Eche", "SS3", 95.5),
                new Student("Abigirl", "Okpe", "SS3", 70.5),
            };
            ////SelectQuery.
            var selectQuery = (from obj in Students
                               select obj).ToList();
            ////BasicQuery.
            var basicQuery = Students.ToList();


            ////MethodSyntax.
            var methodSyntax = Students.SelectMany(obj => obj.Fristname).ToList();

            //var methodSyntax = Students.SelectMany(obj => obj.Surname).ToList();
            //Console.ReadLine();


            //////Using the QuerySytanx.
            //var Querysytanx = from obj in Students
            //                  where obj.CurrentClass == "JSS1"
            //                  select obj;


            //////Using the Method Syntax.
            //var methodSyntax = Students.Where(obj => obj.CurrentClass == "JSS1");


            //////Usung the MixSytnax.
            //var mixSytanx = (from obj in Students
            //                 select obj.ResultAverage).Max();
            //Console.WriteLine("Highest Average " + mixSytanx);


            /////CLASS WORK BELOW..
            //var selectQuery = from obj in Students
            //                   where obj.Fristname == "JSS2" && obj.ResultAverage >= 50
            //                   select obj;

            foreach (var student in basicQuery)
            {
                Console.WriteLine($" Fristname:{student.Fristname} Surname:{student.Surname} CurrentClass:{student.CurrentClass} ResultAverage:{student.ResultAverage}\n");
            }
        }
    }
}