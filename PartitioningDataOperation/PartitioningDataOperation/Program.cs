using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningDataOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TAKE PATRITIONING METHOD..
            int[] numbers = new int[] {1,2,3,4,5,6,7,8,9,10};
            var ms = numbers.Take(5).ToArray();
            Console.WriteLine();
        }
    }
}
