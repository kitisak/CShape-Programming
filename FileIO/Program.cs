using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\ExamData.txt";

            if (File.Exists(path)) {
                Console.WriteLine("File Readly to Exits !!!");
            } else {
                Console.WriteLine("File not Found !!!");
            }

            Console.ReadKey();           
        }
    }
}
