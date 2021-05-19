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

            /*
            // Demo 02 : File.ReadAlllines
            string path = @"D:\ExamData.txt";
            string[] lines;

            try
            {                 
                lines = File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
                Console.WriteLine(lines[2]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.ReadKey();
            }
            */

            /*
            // Demo 03 : File.ReadAllBytes
            string path = @"D:\ExamData.txt";
            byte[] bytes;
            
            try
            {
                bytes = File.ReadAllBytes(path);

                Console.WriteLine(bytes[0]);
                Console.WriteLine(bytes[1]);
                Console.WriteLine(bytes[2]);
                Console.WriteLine(bytes[3]);
                Console.WriteLine(bytes[4]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            */

            // Demo 04 : File.ReadAllText
            string path = @"D:\ExamData.txt";
            string alltext;

            alltext = File.ReadAllText(path);
            Console.WriteLine(alltext);

            Console.ReadKey();

        }
    }
}
