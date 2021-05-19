using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Demo 01 : File.Exists
            string path = @"D:\ExamData.txt";

            if (File.Exists(path)) {
                Console.WriteLine("File Readly to Exists !!!");
            } else {
                Console.WriteLine("File not Found !!!");
            }

            Console.ReadKey();     
            */

            // Demo 02 : File.ReadAlllines

            string path = @"D:\ExamData.txt";
            string[] lines;

            try
            {                 
                lines = File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.ReadKey();
            }
            
        }
    }
}
