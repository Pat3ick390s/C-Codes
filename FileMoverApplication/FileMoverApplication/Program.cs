using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileMoverApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roothpath = @"C:\Users\Student\Downloads";

            string DestinationFoder = @"C:\Users\Student\Downloads\ImageFolder\";

            string[] files = Directory.GetFiles(roothpath, "*.PNG");

            //Checking if Image still exist in the folder.
            if (files.Length ==0)
            {
                
                Console.WriteLine("SORRY, NO IMAGE IN THIS FLODER !");
            }
            else 
            {
                //Checking if thesame Image exists in the folder.
                foreach (string item in files)
                {
                    if(Directory.Exists(DestinationFoder))
                    { 
                        try
                        {
                            File.Move(item, $"{DestinationFoder} {Path.GetFileName(item)}");
                        }
                        catch (IOException err)
                        {
                            Console.WriteLine("SORRY, IMAGE ALEADY EXIST");
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(DestinationFoder);
                        File.Move(item, $"{DestinationFoder} {Path.GetFileName(item)}");
                        Console.WriteLine("SUCESS !!!");
                    }                     
                }
            }
             Console.WriteLine();
        }
    }
}