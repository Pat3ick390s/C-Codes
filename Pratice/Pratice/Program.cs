// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//using system;
//using system. Collection.Generic;

namespace iterate_through_a_list
{
    class program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string> { "value1", "value2", "value3",};
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine("Element#{0} = {0}", i, values[i]);
            }
        }
    }
}